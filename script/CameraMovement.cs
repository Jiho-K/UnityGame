using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stickman;
    private Vector3 offset;
    public Camera cam;

    void Start()
    {
        offset = transform.position - stickman.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = stickman.transform.position + offset;
    }
}
