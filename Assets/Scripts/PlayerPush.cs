/*ECHO NITE 
* Joan Karstrom
* Chapman ID: 2318286
* Email: Karstrom@chapman.edu
* Player Push Script*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour {

    public bool grabbed;
    RaycastHit2D hit;
    public float distance = 2f;
    public Transform holdpoint;
    public float throwforce;
    public LayerMask notgrabbed;

    GameObject box;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (!grabbed)
            {
                Physics2D.queriesStartInColliders = false;
                hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);
                if (hit.collider != null && hit.collider.tag == "grabbable")
                {
                    grabbed = true;
                }
                //grab
            }
            else if (!Physics2D.OverlapPoint(holdpoint.position, notgrabbed))
            {
                grabbed = false;
                if (hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * throwforce;
                }
                //throw
            }
        }

        if (grabbed)
        {
            hit.collider.gameObject.transform.position = holdpoint.position;
        }
            
    }

    /*Drawing on player function (not for game but for me)
     * returns nothing
     * no parameters
     * no exceptions thrown*/
    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * distance);
    }
}
