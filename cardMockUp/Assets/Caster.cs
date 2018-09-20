using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Caster : MonoBehaviour {

    public GameObject arrowCursor;
    public GameObject pivot;
    public float pivotTime;

    Renderer currentHighlightedObject = null;
    Ray pointRay;
    RaycastHit hit;

    public rotate rotateScript;

    Vector3 mousePosition;

    //public float pivotTimer = GetComponent<rotate>().pivotTimeLeft;

    // Use this for initialization
    /*void Start () {

       
    }*/
	
	// Update is called once per frame
	void Update () {

        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

       mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // mousePosition.z = 10;
       //arrowCursor.transform.position = mousePosition;



        if (hit)
        {
            //Debug.Log(hitInfo.collider);
            Renderer hitRenderer = hit.collider.GetComponent<Renderer>();
            hitRenderer.material.color = Color.blue;

            currentHighlightedObject = hitRenderer;

        }
        else if (currentHighlightedObject != null)
        {
            currentHighlightedObject.material.color = Color.white;
            currentHighlightedObject = null;
        }

        if (Input.GetMouseButtonDown(0))
            {
            if (hit.collider.gameObject.name == "card2")
                {
                pivot.SetActive(true);
              
                }
            }

        }
}
