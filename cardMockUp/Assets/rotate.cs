using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    public float rotateSpeed = 16f;
    public Vector3 rotateAxis;

    public float pivotTimeLeft = 10f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       pivotTimeLeft -= Time.deltaTime;

        if (pivotTimeLeft <= 0)
        {
            gameObject.SetActive(false);
            pivotTimeLeft = 0.3f;
            //conjureTimer = 50f;
        }

        transform.Rotate(0, 0, -30 * rotateSpeed * Time.deltaTime);

        Vector3 eulerAngles = transform.localRotation.eulerAngles;
        eulerAngles += rotateAxis * rotateSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(eulerAngles);
        Quaternion.Inverse(gameObject.transform.localRotation);

    }
}
