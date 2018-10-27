using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManeger : MonoBehaviour {

    //public PlayerHealth playerHP;
    public GameObject Box;
    public float spawnTime = 3f;
    public Transform[] spawnpoint;
    // Use this for initialization
    void Start () {
        InvokeRepeating("spawn", spawnTime, spawnTime);
	}
	// Update is called once per frame
	void Update () {
 

    }
    void spawn(){
        int spawnIndex = Random.Range (0, spawnpoint.Length);
        Instantiate(Box, spawnpoint[spawnIndex].position, spawnpoint[spawnIndex].rotation);

    }
}
