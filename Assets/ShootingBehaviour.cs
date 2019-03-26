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
<<<<<<< HEAD

    public float attackDistaince = 10f, fireRate = 0.5f ;
    public GameObject bullet;
    bool combat = false, fire = false;
    void Update() {

        float dist = Vector3.Distance(gameObject.transform.position, tar.transform.position);
        if (tiberium > 0) {

            if (dist < attackDistaince && fire == false)
            {
                fire = true; 
                InvokeRepeating("Attack", 0f, fireRate);
            }

        }else {
            CancelInvoke();
            combat = false;
            GetComponent<Arrive>().targetGameObject = home;
            dist = Vector3.Distance(gameObject.transform.position, home.transform.position);
            if(dist < attackDistaince/2 && home.GetComponent<Base>().tiberium >= 7)

            {
                Debug.Log("Reload");
                home.GetComponent<Base>().tiberium -= 7;
                tiberium = 7;
                fire = false;
                NewTarget(); 

            }
            


        }
	}
    void Attack()
    {
        if (tiberium > 0)
        {
            tiberium -= 1; 
            GameObject bulletSpawned = Instantiate(bullet, transform.position, Quaternion.identity);
        }
        else
        {

        }

    }
    void Refuel()
    {


    }
=======
	void Update () {
		
	}
>>>>>>> parent of d970e36... Update three
}
