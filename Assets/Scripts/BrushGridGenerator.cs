using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushGridGenerator : MonoBehaviour
{
    public GameObject bushPrefab, combatBushPrefab;
    private char[,] bushMap = new char[10, 10];
    private Vector2 bushPos;

    void Start()
    {
        GenerateGrid(bushMap);
        PrintGrid(bushMap);
    }

    private void GenerateGrid(char[,] bushMap)
    {
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                bushMap[x, y] = 'G';        // Good bushes
                int combatBushChance = Random.Range(0, 30);
                if (combatBushChance < 3)
                {
                    bushMap[x, y] = 'B';    // Bad bushes
                }
            } 
        } 
    } 
    private void PrintGrid(char[,] bushMap)
    {
        for (int x = 0;x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                bushPos = new Vector2(x, y);
                if (bushMap [x, y] == 'G')
                {
                    Instantiate(bushPrefab, bushPos, Quaternion.identity);
                }
                if (bushMap[x, y] == 'B')
                {
                    Instantiate(combatBushPrefab, bushPos, Quaternion.identity);
                }
            }
        }
    }
}

    

