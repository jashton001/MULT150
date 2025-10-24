using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    public float movementSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");

        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 translation = new Vector3(mouseX, mouseY, 0) * movementSpeed * Time.deltaTime;

        transform.Translate(translation, Space.Self);

    }
}