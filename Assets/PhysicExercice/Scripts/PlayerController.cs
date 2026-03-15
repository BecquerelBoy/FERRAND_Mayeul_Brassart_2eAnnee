using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera PlayerCamera;

    public NavMeshAgent NavMeshAgent;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void FixedUpdate ()
    {
        if (Input.GetMouseButton(0))
        {
            Ray clickRayCast = PlayerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(clickRayCast,out hit))
            {
                NavMeshAgent.SetDestination(hit.point);
            }
        }
    }
}
