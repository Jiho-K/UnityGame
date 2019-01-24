using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollDown : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera cam;
    private float totalTime;

    void Start()
    {
        cam.enabled = true;
        totalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        if(totalTime <= 5)
        {
            cam.transform.position = new Vector2(-1.2f, 4.5f - (6.25f/5*totalTime));

        }

    }
}
