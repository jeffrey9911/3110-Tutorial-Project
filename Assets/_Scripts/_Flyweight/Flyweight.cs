using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Runtime.InteropServices;
using System.Data.Common;

public class Flyweight : MonoBehaviour
{
    [DllImport("LoadPlugin")]
    private static extern float LoadFromFile(int j, string fileName);


    [DllImport("LoadPlugin")]
    private static extern int GetLines(string fileName);

    List<Item> allItems;

    string fn;

    private void Start()
    {
        allItems = new List<Item>();

        fn = Application.dataPath + "/save.txt";

        LoadItems();
    }

    void LoadItems()
    {
        int numLines = GetLines(fn);

        int maxItems = numLines / 4;

        int infoSet = 0;

        Debug.Log(numLines + " of Lines");


        //using with flyweight
        Item newItem = new Item();
        float y = LoadFromFile(2, fn);


        for(int j = 0; j < 10000; j++)
        {
            for (int i = 0; i < maxItems; i++)
            {
                //without flyweight
                /*
                Item newItem = new Item();

                newItem.itemID = (int)LoadFromFile(infoSet + 0, fn);
                newItem.itemPos.x = LoadFromFile(infoSet + 1, fn);
                newItem.itemPos.y = LoadFromFile(infoSet + 2, fn);
                newItem.itemPos.z = LoadFromFile(infoSet + 3, fn);*/

                //using flyweight
                newItem.itemID = (int)LoadFromFile(infoSet + 0, fn);
                newItem.itemPos.x = LoadFromFile(infoSet + 1, fn);
                newItem.itemPos.y = y;
                newItem.itemPos.z = LoadFromFile(infoSet + 3, fn);

                allItems.Add(newItem);

                infoSet += 4;
            }
            infoSet = 0;
        }

        Debug.Log(allItems.Count + " of items are added!");
    }
}
