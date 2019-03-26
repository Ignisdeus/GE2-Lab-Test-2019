using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehaviour : MonoBehaviour {

    public GameObject[] bacesToAttack = new GameObject [3]; 
	
	    
    void Start()
    {

        GameObject[] allBaces = GameObject.FindGameObjectsWithTag("Bace");
        Color col;
        col = GetComponent<MeshRenderer>().material.color;
        int heldSpot = 0; 
        for (int i = 0; i < allBaces.Length; i++)
        {
            if(allBaces[i].GetComponent<MeshRenderer>().material.color != col)
            {
                bacesToAttack[heldSpot] = allBaces[i];
                heldSpot++; 
            }

        }

    }
	void Update () {
		
	}
}
