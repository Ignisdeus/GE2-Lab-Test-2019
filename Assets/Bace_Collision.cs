using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bace_Collision : MonoBehaviour {


    float amountToRemove = 0.5f; 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            gameObject.GetComponent<Base>().tiberium -= amountToRemove;
            Destroy(other.gameObject); 

        }



    }

    
}
