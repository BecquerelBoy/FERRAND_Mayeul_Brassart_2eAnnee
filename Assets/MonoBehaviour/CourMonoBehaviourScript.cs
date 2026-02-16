using System.Threading.Tasks;
using UnityEngine;

public class CourMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    async Awaitable Start()
    {
        TestAwaitable().Wait(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    async Task TestAwaitable()
    {
        Debug.Log("Start Aswaitable");
        await Awaitable.WaitForSecondsAsync(5);
        Debug.Log("after");
    }
}
