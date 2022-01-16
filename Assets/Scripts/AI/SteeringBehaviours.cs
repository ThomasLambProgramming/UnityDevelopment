using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringBehaviours
{
    
    private Rigidbody _agentRb = null;
    private Rigidbody _targetRb = null;
    private Vector3 _targetPosition = Vector3.zero;

    public void SetAgentRb(Rigidbody a_rigid) => _agentRb = a_rigid;
    public void SetTargetRb(Rigidbody a_rigid) => _targetRb = a_rigid;
    public void SetTargetLocation(Vector3 a_pos) => _targetPosition = a_pos;

    public float _moveSpeed = 0;
    public Vector3 Seek()
    {
        return Vector3.zero;
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
