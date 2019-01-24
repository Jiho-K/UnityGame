using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startScreenText : MonoBehaviour
{

    public Text textField;
    private float totalTime = 0;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        if(totalTime > 6 && totalTime < 7)
        {
            textField.text = "This...";
        } else if(totalTime > 7)
        {
            textField.text = "This is it";

            if (Input.GetKeyDown("a") || Input.touchCount > 0)
            {
                SceneManager.LoadScene(2);
            }
            
        }
        
    }
}
