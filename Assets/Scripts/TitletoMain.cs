using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
//PURPOSE: TO TRANSIITON INTO DIFF SCENES IN THE GAME
//USAGE: PLACE ON EPTY GAME OBJECT IN SCENE 
public class TitletoMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
         
           SceneManager.LoadScene("GameScene");
           
        }
        if (Input.GetKeyDown(KeyCode.Escape)) //BACK TO TITLE

        {
            SceneManager.LoadScene("TitleScene");
        }


    }

  
}
