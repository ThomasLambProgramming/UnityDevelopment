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
		return transform.TransformPoint(Bezier.GetPoint(points[0], points[1], points[2], t));
	}

    //When the component is reset or created this will be called by default (thats really cool)
    public void Reset()
    {
        points = new Vector3[] {
			new Vector3(1f, 0f, 0f),
			new Vector3(2f, 0f, 0f),
			new Vector3(3f, 0f, 0f)
        };
    }
}



public static class Bezier{
    public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
    {
        return Vector3.Lerp(Vector3.Lerp(p0,p1, t), Vector3.Lerp(p1, p2, t), t);
    }
}