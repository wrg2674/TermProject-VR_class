using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCharacter : MonoBehaviour
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
        
    }
    private void look(Vector3 dir)
    {
        camera.transform.position = firePos.position+dir+new Vector3(0.0f,0.1f,0.0f);
        camera.transform.rotation = firePos.rotation;
    }
    private void move()
    {
    Vector3 dir = Vector3.zero;
    Vector3 distance = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            distance += Vector3.forward;
            dir += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            distance += Vector3.forward;
            dir += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            distance += Vector3.forward;
            dir += Vector3.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            distance += Vector3.forward;
            dir += Vector3.back;
        }
        distance = distance.normalized;
        transform.Translate(distance * Time.deltaTime * speed);
        if (dir.magnitude > 0.1f)
        {
            dir = dir.normalized;
            transform.LookAt(transform.position - dir);
            look(dir);
        }

    }
}
