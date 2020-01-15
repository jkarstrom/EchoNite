/*ECHO NITE 
* Joan Karstrom
* Chapman ID: 2318286
* Email: Karstrom@chapman.edu
* End Level Script*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour {

    public string nextLevel;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /*OnTriggerEnter2D function
     * returns nothing
     * parameter: box collider object
     * no exceptions thrown*/
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
