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


    //----Speed Variables----
    [SerializeField] private float _maxSpeed = 5f;
    [SerializeField] private float _maxTurningSpeed = 5f;

    //-----------------------


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
        
    }
    private Vector3 GetDesiredVelocity()
    {
        switch(_currentState)
        {
            case SteeringState.Seek:
                return _steeringBehaviour.Seek();

            case SteeringState.Flee:
                return _steeringBehaviour.Flee();

            case SteeringState.Arrive:
                return _steeringBehaviour.Arrive();

            case SteeringState.Wander:
                return _steeringBehaviour.Wander();

            case SteeringState.Pursuit:
                return _steeringBehaviour.Pursue();
                
            case SteeringState.Evade:
                return _steeringBehaviour.Evade();
        }

        //if all fails
        return Vector3.zero;
    }

    public void SeekPosition(Vector3 a_position)
    {
        _target = a_position;
        _enableMovement = true;
    }
}
