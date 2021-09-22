﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public int platformCount = 200; //How Many total "bubbles are going to spawn"


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < platformCount; i++)
        {
            Vector3 spawnPosition = new Vector3();
            spawnPosition.y += Random.Range(-10f, 50f); // they shoud be vertically this far away from eachother 
            spawnPosition.x += Random.Range(-10f, 10f); // they should horizontally spawn this far away from eachother 
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
