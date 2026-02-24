using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    LookAtConstraint _lookAtReference;

    [SerializeField]
    private GameObject _spherePrefab;

    [SerializeField]
    [Range(0.2f, 5.0f)]
    private float _spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnSphere(_spawnInterval, _spherePrefab));
    }

    private IEnumerator SpawnSphere(float interval, GameObject sphere)
    {
        yield return new WaitForSeconds(interval);
        GameObject newSphere = Instantiate(sphere, new Vector3(0, 0, 0), Quaternion.identity);
        GameObject newSphere.GetComponent
        StartCoroutine(SpawnSphere(interval, sphere));


    }
}