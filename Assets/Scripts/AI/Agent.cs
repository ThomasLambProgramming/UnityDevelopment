using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;

    public Vector3 _target = Vector3.zero;

    public bool _enableMovement = false;

    private SteeringBehaviours _steeringBehaviour = null;


    private Rigidbody _agentRb = null;

    // Start is called before the first frame update
    void Start()
    {
        _agentRb = GetComponent<Rigidbody>();
        _steeringBehaviour = new SteeringBehaviours();
    }

    // Update is called once per frame
    void Update()
    {
        if (_enableMovement && _target != Vector3.zero)
        {

        }
    }

    public void SeekPosition()
    {

    }
}
