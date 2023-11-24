using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCamera : MonoBehaviour
{
    public GameObject character;
    public Transform firePos;
    private float x=0;
    private float y=0;
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
            // 플레이어의 입력을 감지하고 해당 입력에 따라 값을 반환
            // 매개변수 : 입력을 감지할 축
            x += Input.GetAxis("Mouse X")*Time.deltaTime*500;
            y += Input.GetAxis("Mouse Y") * Time.deltaTime*500;

            // 고개 조절
            if (y > 35.0f)
            {
                y = 35.0f;
            }
            if (y < -30.0f)
            {
                y = -30.0f;
            }
            Vector3 mousePosition = new Vector3(-y, x, 0.0f);
            //this.transform.eulerAngles = mousePosition;
            character.transform.eulerAngles = mousePosition;
            //character.transform.rotation = Quaternion.Euler(mousePosition);
            
        }
    }
    
}
