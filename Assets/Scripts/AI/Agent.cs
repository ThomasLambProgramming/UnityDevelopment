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

        switch(_currentState)
        {
            case SteeringState.Seek:
                break;
            case SteeringState.Flee:
                break;
            case SteeringState.Arrive:
                break;
            case SteeringState.Wander:
                break;
            case SteeringState.Pursuit:
                break;
            case SteeringState.Evade:
                break;
        }
    }

    public void SeekPosition(Vector3 a_position)
    {
        _target = a_position;
        _enableMovement = true;
    }
}
