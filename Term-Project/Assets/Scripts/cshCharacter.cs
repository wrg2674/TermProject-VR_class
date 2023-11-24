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
    private void look()
    {

        //camera.transform.position = firePos.position + new Vector3(0.0f, 0.0f, -1.0f);
        //camera.transform.eulerAngles = firePos.transform.eulerAngles;
        /*camera.transform.rotation = firePos.rotation;*/
        //camera.transform.eulerAngles += this.transform.position;
    }
    private void move()
    {
    Vector3 dir = new Vector3(0.0f,0.0f,1.0f);
    Vector3 distance = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            //distance += this.transform.forward;
            distance += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            distance += Vector3.left;
            //distance -= this.transform.right;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            distance += Vector3.right;
            //distance += this.transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            distance += Vector3.back;
            //distance -= this.transform.forward;
        }
        distance = distance.normalized;
        transform.Translate(distance * Time.deltaTime * speed);
        //look();
    }
}
