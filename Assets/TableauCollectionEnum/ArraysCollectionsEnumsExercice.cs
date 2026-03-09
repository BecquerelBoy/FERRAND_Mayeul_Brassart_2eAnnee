using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysCollectionsEnumsExercice : MonoBehaviour
{
    [SerializeField]
    string[] exoArray = new string[10];

    [SerializeField]
    CollectionType typeOfCollection;

    [SerializeField]
    Day days = Day.Monday;

    [ContextMenu("Reset Array")]
    void resetArray()
    {
        Array.Resize(ref exoArray, 10);
    }

    [ContextMenu("Current Collection ?")]
    void wichCollection()
    {
        foreach (int i in collection)
            Debug.Log(i);
    }

    public ICollection collection;
    private void Start()
    {
        Debug.Log(days);
        
        switch (typeOfCollection)
        {
            case CollectionType.Array:
                collection = new int[10];
                break;

            case CollectionType.List:
                collection = new List<int>(5);
                break;

            case CollectionType.Queue:
                collection = new Queue(4);
                break;

            case CollectionType.Stack:
                collection = new Stack(7);
                break;
        }
    }
}
