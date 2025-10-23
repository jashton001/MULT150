using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light lightComponent;

    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();

        if (lightComponent == null)
        {
            Debug.LogError("Error!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            if (lightComponent != null)
            {
                lightComponent.enabled = !lightComponent.enabled;

                Debug.Log("Light toggled: " + (lightComponent.enabled ? "ON" : "OFF"));
            }
        }
    }
}
