using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float tiberium = 0;

    public TextMeshPro text;

    public GameObject fighterPrefab;
    public Color col;


    // Start is called before the first frame update
    void Start()
    {
       
        //col = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255), 255);
        // start with a bace of 5 tiberiu;
        tiberium = 5f;
        InvokeRepeating("GetTiberium", tiberiumSpawnRate, tiberiumSpawnRate);
        //foreach (Renderer r in GetComponentsInChildren<Renderer>())
        //{
        //r.material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
        //}
        GetComponent<MeshRenderer>().material.color = col; 
    }

    // Update is called once per frame
    //spawnCost 
    public int spawnCost = 10;
    public Transform spawnPoint; 
    void Update()
    {

        if(tiberium > spawnCost)
        {
            tiberium -= spawnCost; 
            Instantiate(fighterPrefab, spawnPoint.position, Quaternion.identity);

        }
        text.text = "" + tiberium;
    }

    public float tiberiumSpawnRate = 1f, amountOfTiberiumPerTick = 1f; 
    void GetTiberium()
    {
        // get tiberium at a set rate
        tiberium += amountOfTiberiumPerTick;

    }
}
