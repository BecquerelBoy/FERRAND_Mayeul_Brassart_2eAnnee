using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private int _starTriangleSize = 2;
    [SerializeField]
    private int _userAge = 2;
    [SerializeField]
    private int _factorialValue = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CheckUserAge();
        DrawTriangle(_starTriangleSize);
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

        else if ( _userAge < 0)
        {
            Debug.Log("Age is negative");
        }

    }

    private void DrawTriangle(int n)
    {
        string space = " ";
        string star = "*";
        string back = "\n";
        string text = "";

        if (_starTriangleSize <= 0)
        {
            Debug.Log("Non valid triangle size");
        }

        for (int l = 0; l < n; l++)
        {
            for (int e = 0; e < ((n - 1) - l); e++)
            {
                text = text + space;
            }

            for (int s = 0; s < (n - (n - 1) + 2l); s++)
            {
                text = text + star;
            }

            text = text + back;
        }

        Debug.Log(text);
    }
}
