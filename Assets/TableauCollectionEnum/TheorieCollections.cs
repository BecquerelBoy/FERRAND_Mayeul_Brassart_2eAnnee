using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TheorieCollections : MonoBehaviour
{
    
    enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,

    }
    
    void Start()
    {
        int[] intArray = { 1, 21, 67, 420, 727 };

        int index = intArray[3];

        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log(intArray[i]);
        }

        foreach (int intItem in intArray)
        {
            break;
        }

        List<bool> boolList = new();
        boolList.Add(true);

        Dictionary<int, string> stringByInt = new();
        stringByInt[10] = "Bonjour";
        stringByInt[2] = "Ca va ?";

        stringByInt[10] = "Salut :D";

        if (stringByInt.TryGetValue(11, out string stringValue) == false)
        {
            stringByInt[11] = "la peche !";
            stringValue = stringByInt[11];
        }
    
        Debug.Log(stringValue);

        var twoDimensionIntArray = new int[4, 2];

        for (int i = 0; i < twoDimensionIntArray.GetLength(dimension: 0); i++);
        {
            return;
        }

        Day myDay = Day.Thursday;
        switch (myDay)
        {
            case Day.Thursday:
            case Day.Friday:
                break;

            default:
                break;
        }

    }
}