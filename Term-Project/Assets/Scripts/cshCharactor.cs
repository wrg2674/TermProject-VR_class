using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCharactor : MonoBehaviour
{
    public GameObject camera;
    public Transform firePos;
    private float speed = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
        look();
    }
    void look()
    {
        Vector3 pos = Vector3.zero;
        Vector3 dir = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos -= Vector3.forward;
            dir += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos -= Vector3.left;
            dir += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos -= Vector3.right;
            dir += Vector3.right;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos -= Vector3.back;
            dir += Vector3.back;
        }
        dir = dir.normalized;
        if(dir.magnitude > 0.1f)
        {
            camera.transform.position = transform.position + pos;
            camera.transform.LookAt(transform.position + dir);
        }
        
    }
    void move()
    {
    Vector3 dir = Vector3.zero;
    Vector3 distance = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            distance += Vector3.forward;
            dir += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            distance += Vector3.forward;
            dir += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            distance += Vector3.forward;
            dir += Vector3.right;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            distance += Vector3.forward;
            dir += Vector3.back;
        }
        distance = distance.normalized;
        transform.Translate(distance * Time.deltaTime * speed);
        if(dir.magnitude > 0.1f)
        {
            transform.LookAt(transform.position + dir);
            
        }
    }
}
