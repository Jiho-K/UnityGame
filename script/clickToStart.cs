using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickToStart : MonoBehaviour
{
    // Start is called before the first frame update

    public Text textField;
    private float totalTime = 0;

    void Start()
    {
        //countText.AddComponent<Text>;
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        if (totalTime < 8)
        {
            textField.text = "";
            //Debug.Log(".");
        }
        else if((int)totalTime%2 == 1)
        {
            textField.text = "Click to Start";
        }
        else
        {
            textField.text = "";
        }
    }
}
