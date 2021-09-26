using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PURPOSE: To randomly generate platforms 
//USAGE: Place this on an empty game object called Game Manager
public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public int platformCount; //How Many total "bubbles are going to spawn"


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < platformCount; i++)
        {
            Vector3 spawnPosition = new Vector3();
            spawnPosition.y += Random.Range(-10f, 100f); // they shoud be vertically this far away from eachother 
            spawnPosition.x += Random.Range(-8f, 8f); // they should horizontally spawn this far away from eachother 
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
