using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{
    private int num = 0;
    private float run = 0;
    private float time = 0;

    void Start(){
		
        
        
    }

    private void Update()
    {
        if (time >= 5f)
        {
            num = Random.Range(0, 2);
            run = Random.Range(-0.05f, -0.01f);

            if (num == 0)
            {
                iTween.MoveBy(gameObject, iTween.Hash("y", run, "easeType", "easeInOutQuad", "time", 3 ,"loopType", "pingPong", "delay", 0f));
            }
            if (num == 1)
            {
                iTween.MoveBy(gameObject, iTween.Hash("x", run, "easeType", "easeInOutQuad", "time", 2, "loopType", "pingPong", "delay", 0f));
            }
            if (num == 2)
            {
                iTween.MoveBy(gameObject, iTween.Hash("z", run, "easeType", "easeInOutQuad", "time", 2, "loopType", "pingPong", "delay", 0f));
            }
            time = 0;

        }
        time += Time.deltaTime;
    }
}

