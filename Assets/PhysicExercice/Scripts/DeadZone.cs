using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField]
    private int sphereCount = 0;
    [SerializeField]
    private GameObject WinCollider;

    // This function is called when a ball enter the deadzone
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Destructible"))
        {
            Object.Destroy(other.gameObject);
            sphereCount++;

            if (sphereCount == 4)
            {
                WinCollider.SetActive(true);
            }
        }
    }
}
