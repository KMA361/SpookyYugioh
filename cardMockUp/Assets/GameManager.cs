using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public GameObject optionCard;
    public GameObject arrowCursor;

    Renderer currentHighlightedObject = null;
    Ray pointRay;
    RaycastHit2D hit;

    Vector2 mousePosition;

    public Transform target;
    Camera cam;

    // Use this for initialization
    void Start()
    {

        cam = GetComponent<Camera>();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 screenPos = cam.WorldToScreenPoint(target.position);

        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePosition.z = 10;
        //arrowCursor.transform.position = mousePosition;

        if (hit)
             {
            //Debug.Log(hitInfo.collider);
            Renderer hitRenderer = hit.collider.GetComponent<Renderer>();
            hitRenderer.material.color = Color.blue;
            }
        }
}
