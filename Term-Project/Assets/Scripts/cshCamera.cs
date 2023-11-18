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
        if (Input.GetMouseButtonDown(1))
        {
            // 플레이어의 입력을 감지하고 해당 입력에 따라 값을 반환
            // 매개변수 : 입력을 감지할 축
            Vector3 mousePosition = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0.0f);
            //this.transform.eulerAngles += mousePosition;
            this.transform.LookAt(mousePosition);
            character.transform.rotation = Quaternion.Euler(this.transform.eulerAngles);
        }
    }
}
