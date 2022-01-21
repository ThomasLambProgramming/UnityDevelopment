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
    public Vector3 Flee()
    {
        Vector3 desiredVel = (_agentTransform.position - _targetPosition).normalized * _maxSpeed;
        //Remember left is goal vector, right is the one we want to find out how to get to the left from
        return desiredVel - _agentRb.velocity;
    } 
    public Vector3 Arrive()
    {
        Vector3 toTarget = _targetPosition - _agentTransform.position;
        float distance = toTarget.magnitude;

        if (distance > 0)
        {
            //This is just a variable to help with the scaling and values of the decel
            float decelerationTweaker = 0.3f;

            //calculate the speed required to reach the target
            float velNeeded = distance / (2 * decelerationTweaker);

            if (velNeeded > _maxSpeed)
                velNeeded = _maxSpeed;

            return toTarget * (velNeeded / distance);
        }
        return Vector3.zero;
    }
    
    public Vector3 Pursue()
    {
        return Vector3.zero;
    }
    public Vector3 Evade()
    {
        return Vector3.zero;
    }
    public Vector3 Wander()
    {
        return Vector3.zero;
    }
}
