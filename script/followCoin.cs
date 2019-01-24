using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class followCoin : MonoBehaviour
{
    public Camera cam;
    private float totalTime;


    // Start is called before the first frame update
    void Start()
    {
        totalTime = 0;
        cam.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        
        if(totalTime <= 3 && totalTime > 1)
        {
           // Debug.Log(Time.deltaTime);
            cam.orthographicSize = 1.5f + ((totalTime - 1) * 3.5f/2f);
            cam.transform.position = new Vector3(5 - 5/2 * (totalTime -1), 1 - 1.5f / 2 * (totalTime - 1) , 0);
            // will become 5 when executed
        } if(totalTime > 5)
        {
            SceneManager.LoadScene(1);
        }
    }
}
