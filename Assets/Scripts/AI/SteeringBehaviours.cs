using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringBehaviours
{
    private Transform _agentTransform = null;
    private Rigidbody _agentRb = null;
    private Rigidbody _targetRb = null;
    private Vector3 _targetPosition = Vector3.zero;
    private float _maxSpeed = 5f;

    public void SetAgentRb(Rigidbody a_rigid) => _agentRb = a_rigid;
    public void SetTargetRb(Rigidbody a_rigid) => _targetRb = a_rigid;
    public void SetTargetLocation(Vector3 a_pos) => _targetPosition = a_pos;
    public void SetSpeed(float a_maxSpeed) => _maxSpeed = a_maxSpeed;
    public void SetAgentTransform(Transform a_transform) => _agentTransform = a_transform;
    
    public float _moveSpeed = 0;
    
    
    //The following behaviours are marked down as 1,2,3,4,5 etc on the controls for the user.
    public Vector3 Seek()
    {
        Vector3 desiredVel = (_targetPosition - _agentTransform.position).normalized * _maxSpeed;
        //Remember left is goal vector, right is the one we want to find out how to get to the left from
        return desiredVel - _agentRb.velocity;
    }
    //Made a second one with a parameter overload
    public Vector3 Seek(Vector3 a_seekPosition)
    {
        Vector3 desiredVel = (a_seekPosition - _agentTransform.position).normalized * _maxSpeed;
        //Remember left is goal vector, right is the one we want to find out how to get to the left from
        return desiredVel - _agentRb.velocity;
    }

    public Vector3 Flee()
    {
        Vector3 desiredVel = (_agentTransform.position - _targetPosition).normalized * _maxSpeed;
        //Remember left is goal vector, right is the one we want to find out how to get to the left from
        return desiredVel - _agentRb.velocity;
    } 
    public Vector3 Flee(Vector3 a_fleePosition)
    {
        Vector3 desiredVel = (_agentTransform.position - a_fleePosition).normalized * _maxSpeed;
        //Remember left is goal vector, right is the one we want to find out how to get to the left from
        return desiredVel - _agentRb.velocity;
    } 
    public Vector3 Arrive(float a_decelRate)
    {
        Vector3 toTarget = _targetPosition - _agentTransform.position;
        float distance = toTarget.magnitude;

        if (distance > 0)
        {
            //This is just a variable to help with the scaling and values of the decel
            float decelerationTweaker = 0.6f;

            //calculate the speed required to reach the target
            float velNeeded = distance / (decelerationTweaker * a_decelRate);

            if (velNeeded > _maxSpeed)
                velNeeded = _maxSpeed;

            return toTarget * (velNeeded / distance);
        }
        return Vector3.zero;
    }
    
    public Vector3 Pursue()
    {
        Vector3 toTarget = _targetPosition - _agentTransform.position;

        float relativeHeading = Vector3.Dot(_agentRb.velocity.normalized, _targetRb.velocity.normalized);

        //Acos(0.95) = 18 degrees
        //small note i did not know that is how you get angles from the dot product, very useful for designers variable setting.
        
        //this is a check that the agent is moving at least toward the target and the target is heading straight for the agent
        //then we do not need to look ahead and instead just seek the target
        if (Vector3.Dot(toTarget, _agentRb.velocity.normalized) > 0 && relativeHeading < -0.95)
        {
            return Seek();
        }

        float lookAheadAmount = toTarget.magnitude / (_maxSpeed + _targetRb.velocity.magnitude);

        return Seek(_targetPosition + _targetRb.velocity * lookAheadAmount);
    }
    public Vector3 Evade()
    {
        //the heading chekcing is not needed for the evade function
        Vector3 toTarget = _targetPosition - _agentTransform.position;

        float lookAheadAmount = toTarget.magnitude / (_maxSpeed + _targetRb.velocity.magnitude);

        return Flee(_targetPosition + _targetRb.velocity * lookAheadAmount);
    }

    //This is to get a time to wait for the steering behaviour to turn around to face the current target (think how long a tank takes to turn around)
    public float TurnAroundTime()
    {
        Vector3 toTarget = (_targetPosition - _agentTransform.position).normalized;

        float dot = Vector3.Dot(_agentRb.velocity.normalized, toTarget);

        /*
        There was a whole explaination of this however
        get a coefficient for the turning rate of the vehicle (make it a param probably)
        0.5 = this function will return a time of 1 second for the vehicle to turn around
        */
        float coefficientScale = 0.5f;

        //since dot will give 1 if forward then no time is really needed
        //but if -1 then it will scale accordingly
        return (dot - 1) * -coefficientScale;
    }





    
    public Vector3 Wander()
    {
        return Vector3.zero;
    }
}
