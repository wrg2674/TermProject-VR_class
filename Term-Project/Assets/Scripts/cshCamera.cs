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
            // �÷��̾��� �Է��� �����ϰ� �ش� �Է¿� ���� ���� ��ȯ
            // �Ű����� : �Է��� ������ ��
            x += Input.GetAxis("Mouse X")*Time.deltaTime*500;
            y += Input.GetAxis("Mouse Y") * Time.deltaTime*500;

            // �� ����
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
