using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshWind : MonoBehaviour
{
    public Vector3 windDirection = Vector3.zero;
    public float windForce = 0.0f;
    public GameObject player;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<cshFirePowder>().isInDoor == false)
        {
            time += Time.deltaTime;
            if (time >= 10.0f)
            {
                changeWind();
                time = 0.0f;
            }
        }
    }
    public void changeWind()
    {
        windDirection.x = Random.Range(-0.5f, 0.5f);
        windDirection.y = Random.Range(-0.5f, 0.5f);
        windDirection.z = Random.Range(-0.5f, 0.5f);
        windForce = Random.Range(100.0f, 500.0f);
    }
    public Vector3 getWindDirection()
    {
        return windDirection;
    }
    public float getWindForce()
    {
        return windForce;
    }
}
