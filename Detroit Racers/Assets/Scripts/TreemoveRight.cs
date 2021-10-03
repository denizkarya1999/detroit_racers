using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreemoveRight : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startPosition;
    Vector3 startSize1;
    void Start()
    {

        startPosition = transform.position;
        startSize1 = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1f){

            //Debug.Log(transform.position);
            transform.position += new Vector3(0.03f, -0.012f, 0);
            transform.localScale += new Vector3(0.2f, 0.2f, 0);
            if (transform.position.y < -7)
            {
                transform.position = startPosition;
                transform.localScale = startSize1;

            }
        }


    }
}
