/*ECHO NITE 
* Joan Karstrom
* Chapman ID: 2318286
* Email: Karstrom@chapman.edu
* Load on Click Script*/
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour
{
    /*Load Scene function
     * returns nothing
     * parameters: level number to load to 
     * no exceptions thrown*/
    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }

}