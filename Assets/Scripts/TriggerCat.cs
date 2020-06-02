using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCat : MonoBehaviour {

    public GameObject kittenPrefab;
    public GameObject kitten;
    public Transform spawn;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (kitten == null)
            {
                kitten = Instantiate(kittenPrefab, spawn.position, Quaternion.Euler(0,-90,0));
            }
            
        }
    }
}
