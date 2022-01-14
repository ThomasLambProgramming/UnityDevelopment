using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    private Vector3 _target = Vector3.zero;
    public bool _enableMovement = false;
    private SteeringBehaviours _steeringBehaviour = null;
    public SteeringState _currentState = SteeringState.Seek;
    private Rigidbody _agentRb = null;

    // Start is called before the first frame update
    void Start()
    {
        _agentRb = GetComponent<Rigidbody>();
        _steeringBehaviour = new SteeringBehaviours();
        _steeringBehaviour.SetAgentRb(_agentRb);
    }

    // Update is called once per frame
    void Update()
    {

        if (!_enableMovement || _target == Vector3.zero)
            return;

        Vector3 desiredVelocity = Vector3.zero;
        switch(_currentState)
        {
            case SteeringState.Seek:
                desiredVelocity = _steeringBehaviour.Seek();
                break;
            case SteeringState.Flee:
                desiredVelocity = _steeringBehaviour.Flee();
                break;
            case SteeringState.Arrive:
                desiredVelocity = _steeringBehaviour.Arrive();
                break;
            case SteeringState.Wander:
                desiredVelocity = _steeringBehaviour.Wander();
                break;
            case SteeringState.Pursuit:
                desiredVelocity = _steeringBehaviour.Pursue();
                break;
            case SteeringState.Evade:
                desiredVelocity = _steeringBehaviour.Evade();
                break;
        }
    }

    public void SeekPosition(Vector3 a_position)
    {
        _target = a_position;
        _enableMovement = true;
    }
}
