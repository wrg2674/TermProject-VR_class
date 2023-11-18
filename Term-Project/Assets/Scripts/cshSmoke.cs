using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshSmoke : MonoBehaviour
{
    public GameObject Env;
    public GameObject Fire;
    private GameObject[] air;
    private float time = 0;
    private int index = 0;
    private int size = 0;
    // Start is called before the first frame update
    void Start()
    {
        setEnv();
    }

    // Update is called once per frame
    void Update()
    {
        if(Fire != null)
        {
            airPollusion();
        }
        else
        {
            cleanAir();
        }
    }
    void setEnv()
    {
        size = Env.transform.childCount;
        air = new GameObject[size];
        for(int i=0; i < size; i++)
        {
            air[i] = Env.transform.GetChild(i).gameObject;
        }
    }
    void changeAirCondition(int idx)
    {
        air[idx].GetComponent<Renderer>().material.color = new Color(0.2f, 0.2f, 0.2f, 0.5f);
    }
    void airPollusion()
    {
        if (time >= 10.0f)
        {
            changeAirCondition(index);
            time = 0;
            index = (index + 1) % size;
        }
        time += Time.deltaTime;
    }
    void cleanAir()
    {
        for(int i=0; i < size; i++)
        {
            air[i].GetComponent<Renderer>().material.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
        }
    }
}
