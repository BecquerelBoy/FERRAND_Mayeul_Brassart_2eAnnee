using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] 
    private float _bulletSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * Time.deltaTime * _bulletSpeed);
    }
}
