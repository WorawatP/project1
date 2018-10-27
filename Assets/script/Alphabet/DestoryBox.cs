using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBox : MonoBehaviour {
    public float destoryTime = 3.0f;

	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject, destoryTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
