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
    public Vector3 Seek()
    {
        Vector3 desiredVel = (_targetPosition - _agentTransform.position).normalized * _maxSpeed;
        //Remember left is goal vector, right is the one we want to find out how to get to the left from
        return desiredVel - _agentRb.velocity;
    }
    public Vector3 Arrive()
    {
        return Vector3.zero;
    }
    public Vector3 Flee()
    {
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
