using UnityEngine;

public class TheorieScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        const int MAX_HEALTH_POINT = 100;
        
        int healthPoints = 10;

        int potionHealthPoints = 5;

        healthPoints += potionHealthPoints;

        healthPoints++;

        float positionX = .9f;

        bool isRealLife = true;

        string PlayerName = "Michel";

        healthPoints = int.Parse("255");

        int modulo = 3 % 2;

        string debugString = $"Player's health points : { healthPoints }"; // interpolation
        debugString = "Player's health points:" + healthPoints; // concatenation

        (healthPoints, potionHealthPoints) = (potionHealthPoints, healthPoints);

        float healthPointsFloat = (float)healthPoints;

        object healthPointsObject = healthPoints;

        var manaPoints = 10;

        manaPoints = Increment(manaPoints);
        manaPoints = Decrement(manaPoints);

        Method(.5f, 4, 6, 7, 12, 987456312);
    }

    int Increment(int value)
    {
        return value + 1;
    }

    int Decrement(int value)
    {
        return value - 1;
    }

    void Method(float floatvalue = 10, params int[] values) // Enlevé le point-virgule
    {
        return;

        // ne s'execute pas
    }
}