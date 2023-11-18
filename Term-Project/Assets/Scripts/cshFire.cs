using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshFire : MonoBehaviour
{
    private float HP = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "POWDER")
        {
            Destroy(other.gameObject);
            HP -= 10.0f*Time.deltaTime;
            if(HP <= 0)
            {
                HP = 0;
                Destroy(this.gameObject);
            }
            Debug.Log(HP);
            changeScale();
        }
    }
    void changeScale()
    {

    }
}
