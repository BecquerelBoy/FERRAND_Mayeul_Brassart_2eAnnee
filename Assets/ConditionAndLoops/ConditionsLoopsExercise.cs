using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private int _starTriangleSize = 2;
    [SerializeField]
    private int _userAge = 2;
    [SerializeField]
    private int _factorialValue = 2;

    void Start()
    {
        CheckUserAge();
        DrawTriangle(_starTriangleSize);
        PrintFactorial();
    }

    private void CheckUserAge()
    {
        if (_userAge < 18)
        {
            Debug.Log("Minor");
        }

        else if (_userAge < 64)
        {
            Debug.Log("Adult");
        }

        else if (_userAge > 64)
        {
            Debug.Log("Retired");
        }

        else if (_userAge < 0)
        {
            Debug.Log("Age is negative");
        }

    }

    void DrawTriangle(int n)
    {
        string space = " ";
        string star = "*";
        string back = "\n";
        string text = "";

        if (n > 0)
        {
            for (int l = 0; l < n; l++)
            {
                for (int e = 0; e < ((n - 1) - l); e++)
                {
                    text = text + space;
                }

                for (int s = 0; s < (n - (n - 1) + 2 * l); s++)
                {
                    text = text + star;
                }

                text = text + back;
            }

            Debug.Log(text);
        }

        else
        {
            Debug.Log("Invalid number of stars");
        }
    }


    private void PrintFactorial()
    {
        // Check if the value can be calculated
        if (_factorialValue < 0)
        {
            Debug.LogError("Error: Factorial is not defined for negative numbers.");
            return;
        }

        if (_factorialValue > 20)
        {
            Debug.LogWarning("Warning: Factorial of numbers greater than 20 may cause overflow.");
        }

        // Calculate factorial
        long factorial = 1;
        for (int i = 2; i <= _factorialValue; i++)
        {
            factorial *= i;
        }

        // Display result
        Debug.Log($"The factorial of {_factorialValue}! = {factorial}");
    }
}