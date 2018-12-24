using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class delete : MonoBehaviour {

    private float time = 30;
    private float time2 = 0;
    private int count = 0;
    private bool f = true;
    private int[] i = { -1, 1 };

    public TextMesh time_text;
    public TextMesh text;
    public AudioSource patyan;
    public GameObject[] ban;
    

    void Start ()
    {
        text.text = "0";
	}
	
	
	void Update ()
    {
        if (time > 0 && count > 0)
        {
            time -= Time.deltaTime;
            time_text.text = time.ToString("0#.#0");
        }
        else if(count > 0)
        {
            time_text.text = "00.00";
            //f = false;
            ban[1].SetActive(true);
            ban[0].SetActive(false);
            time2 += Time.deltaTime;
        }

        if (time2 > 2)
        {
            //SceneManager.LoadScene("main");
        }
        
	}
    

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("ok") && f)
        {
            
            col.GetComponent<Transform>().position = new Vector3(Random.Range(0.6f, 1.1f) * i[Random.Range(0,1)], 1.5f, Random.Range(0.43f, 1f) * i[Random.Range(0, 1)]);
            count++;
            text.text = count.ToString();
            patyan.Play();
        }
    }
}
