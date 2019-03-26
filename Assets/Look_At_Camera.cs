using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look_At_Camera : MonoBehaviour {



    public GameObject targetToLookAt; 
	void Update () {
        transform.LookAt(targetToLookAt.transform);
        //transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x , gameObject.transform.rotation.y, gameObject.transform.rotation.z );
	}
}
