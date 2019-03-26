using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bace_Collision : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bullet")
        {

            GetComponent<Base>().tiberium -= 0.5f;
            Destroy(other.gameObject);

        }

    }



  
}
