using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    [SerializeField] private List<Agent> _agents = new List<Agent>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hit = new RaycastHit();
            
            if (Physics.Raycast(ray, out hit, 1000))
            {
                if (hit.transform.CompareTag("Ground"))
                {
                    foreach(Agent agent in _agents)
                    {
                        agent._target = hit.transform.position;
                    }
                }
            }
        }
    }
}
