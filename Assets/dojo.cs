using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dojo : MonoBehaviour {

    private Vector3 dojou;
    private int[] i = { -1, 1};
    private bool f = true;
    int c = 0;


    public GameObject jojo;


    void Start ()
    {
        for (int a = 0; a < 20; a++)
        {
            dojou = new Vector3(Random.Range(0.6f, 1.1f) * i[Random.Range(0, 1)], 1.5f, Random.Range(0.43f, 1f) * i[Random.Range(0, 1)]);
            Instantiate(jojo, dojou, Quaternion.identity);
        }
    }
	
	
	void Update ()
    {
        
	}
}
