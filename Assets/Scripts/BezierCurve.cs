using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Bezier curves are defined by a sequence of points, it starts at first point
//and ends at the last point but does not need to go though any middle points

//instead though points pull the curve away from being a straight line
public class BezierCurve : MonoBehaviour
{
    public Vector3[] points;

    public Vector3 GetPoint (float t) {
		return transform.TransformPoint(Bezier.GetPoint(points[0], points[1], points[2], points[3], t));
	}

    public Vector3 GetVelocity(float t) 
    {
        //get first derivate gives a velocity vector so we dont need the current position of the object and we 
        //want the world position of the points to know its velocity direction in world space only

        //small note about transformdirection while im looking at it, the vector that direction takes will be the same length
        //but transform point will apply the scale as well
        return transform.TransformPoint(Bezier.GetFirstDerivate(points[0], points[1], points[2], t)) - transform.position;
    }
    public Vector3 GetDirection(float t) => GetVelocity(t).normalized;

    //When the component is reset or created this will be called by default (thats really cool)
    public void Reset()
    {
        points = new Vector3[] {
			new Vector3(1f, 0f, 0f),
			new Vector3(2f, 0f, 0f),
			new Vector3(3f, 0f, 0f),
            new Vector3(4f, 0f, 0f)
        };
    }
}



public static class Bezier{
    public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
    {
        //So This is the basic version of a quad bezier
        //return Vector3.Lerp(Vector3.Lerp(p0,p1, t), Vector3.Lerp(p1, p2, t), t);

        //The polynomial function version (basically the equation version) (polynomimal is like
        //y = 2x + 3 but it just cant contain division (so it will always be able to be derived i think))
        //B(t) = (1 - t)2 P0 + 2 (1 - t) t P1 + t2 P2 is the formula (catlikecoding tutorial)

        t = Mathf.Clamp01(t);
        float oneMinusT = 1f - t;

        //Yeah thats a massive thing refer to above formula with t being the lerp amount
        return oneMinusT * oneMinusT * p0 + 2f * oneMinusT * t * p1 + t * t * p2;
    }

    public static Vector3 GetFirstDerivate(Vector3 p0, Vector3 p1, Vector3 p2, float t)
    {
        //First Derivate for the polynomial function above in get point

        //From explaination on tutorial derivative of a function measures its rate of change
        //f(t) = t^2 = 2t
        //f(t) = 3 is constant so it = 0

        //B'(t) = 2 (1 - t) (P1 - P0) + 2 t (P2 - P1).
        return 2f * (1f - t) * (p1 - p0) + 2f * t * (p2 - p1);

        //This function gives back lines tangent to the curve which can be interpreted as the speed with which we move along the curve
        //(it seems to give 90 degrees from the up of the wire point)
    }

    //Overload functions for a cubic bezier curve (cause it contains 3 sections)
    public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
    {
        t = Mathf.Clamp01(t);
        float oneMinusT = 1f - t;

        //B(t) = (1 - t)3 P0 + 3 (1 - t)2 t P1 + 3 (1 - t) t2 P2 + t3 P3
        //formula i think comes from the lerping logic then expanded with variables then condensed to 
        //be a polynominal
        return 
            oneMinusT * oneMinusT * oneMinusT * p0 +
			3f * oneMinusT * oneMinusT * t * p1 +
			3f * oneMinusT * t * t * p2 +
			t * t * t * p3;
    }
    public static Vector3 GetFirstDerivative (Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t) 
    {
        t = Mathf.Clamp01(t);
		float oneMinusT = 1f - t;
		
        //B'(t) = 3 (1 - t)2 (P1 - P0) + 6 (1 - t) t (P2 - P1) + 3 t2 (P3 - P2).
        //formula for first diriv

        return
			3f * oneMinusT * oneMinusT * (p1 - p0) +
			6f * oneMinusT * t * (p2 - p1) +
			3f * t * t * (p3 - p2);
	}
    
}