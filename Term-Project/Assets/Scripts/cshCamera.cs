using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCamera : MonoBehaviour
{
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseInput();
    }
    void MouseInput()
    {
        if (Input.GetMouseButton(1))
        {
            Vector3 mousePosition = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0.0f);
            this.transform.eulerAngles += mousePosition;
            character.transform.rotation = Quaternion.Euler(this.transform.eulerAngles);
        }
    }
}
