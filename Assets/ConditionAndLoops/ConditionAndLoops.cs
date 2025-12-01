using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ConditionBoucle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int playerCount = 2;

        switch (playerCount)
        {
            case 1:
                Debug.Log("One Player");
                break;

            case 2:
                Debug.Log("Two Player");
                break;

            case 3:
                Debug.Log("Three Player");
                break;

            default:
                Debug.Log("No Player");
                break;
        }

        bool newPlayer = true;
        playerCount = newPlayer ? playerCount + 1 : playerCount;

        string playerName = null;
        playerName = playerName ?? "none";

        for (int i = 0; i == 10; i++)
        {
            if (i % 2 == 1);
            {
                continue;
            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
