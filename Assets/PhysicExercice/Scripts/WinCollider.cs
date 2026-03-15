using Unity.VisualScripting;
using UnityEngine;

public class WinCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You Win ! :D");
        }
    }
}
