using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    [SerializeField] private float _cameraMoveSpeed = 5f;
    [SerializeField] private float _cameraRotateSpeedX = 5f;
    [SerializeField] private float _cameraRotateSpeedY = 5f;
    [SerializeField] private LocationMarker _markerObject = null;
    [SerializeField] private List<Agent> _agents = new List<Agent>();

    private bool _allowCameraRotation = false;
    
    void Update()
    {
        GetCameraRotation();
        GetCameraRotation();
        GetMouse();
    }
    private void GetMovementInput()
    {
        Vector3 _moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            _moveDirection += Camera.main.transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _moveDirection += -Camera.main.transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _moveDirection += -Camera.main.transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _moveDirection += Camera.main.transform.right;
        }
        if (_moveDirection != Vector3.zero)
        {
            Camera.main.transform.position += _moveDirection.normalized * _cameraMoveSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _allowCameraRotation = !_allowCameraRotation;
            Debug.Log("Allow Rotation is currently " + _allowCameraRotation);
        }
    }
    private void GetCameraRotation()
    {
        if (_allowCameraRotation)
        {
            float mouseX = Input.GetAxis("Mouse X") * _cameraRotateSpeedX;
            float mouseY = Input.GetAxis("Mouse Y") * -_cameraRotateSpeedY;

            /*
            Didn't understand how to do the rotation of the camera so just found it online
            */
            Quaternion rotation = Camera.main.transform.rotation;
            Quaternion horiz = Quaternion.AngleAxis(mouseX, Vector3.up);
            Quaternion vert = Quaternion.AngleAxis(mouseY, Vector3.right);
            Camera.main.transform.rotation = horiz * rotation * vert;
            //Yeah dont know how the multiplication works with that, I will study this later.
        }
    }
    private void GetMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit = new RaycastHit();
            
            if (Physics.Raycast(ray, out hit, 1000))
            {
                if (hit.transform.CompareTag("Ground"))
                {
                    _markerObject.SetNewPosition(hit.point);

                    foreach(Agent agent in _agents)
                    {
                        agent.SeekPosition(hit.transform.position);
                    }
                }
            }
        }
    }
}
