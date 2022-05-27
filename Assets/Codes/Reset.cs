using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    
    public bool camReversed = false;
    Camera cam;


    private void Start()
    {
        Reset[] ResetScripts = FindObjectsOfType<Reset>();
        int i = 0;
        foreach (Reset rs in ResetScripts)
        {
            if (i > 0)
            {
                Destroy(rs.gameObject);
            }
            i++;
        }
        
        DontDestroyOnLoad(gameObject);
        cam = Camera.main;
        if (camReversed)
        {
            cam.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else
        {

        }


    }
    void Update()
    {


        //Restart
        if (Input.GetKeyDown(KeyCode.R))
        {

            camReversed = !camReversed;

            
            

            Restart();
        }


    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
