using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
public class MyButton
{
    private string name;
    public MyButton(string name)
    {
        this.name = name;
    }
    public void doWork(Transform environment)
    {
        for (int i = 0; i < environment.childCount; i++)
        {
            for (int j = 0; j < environment.GetChild(i).childCount; j++)
            {
                float red = environment.GetChild(i).GetChild(j).gameObject.GetComponent<Renderer>().material.color.r;
                float green = environment.GetChild(i).GetChild(j).gameObject.GetComponent<Renderer>().material.color.g;
                float blue = environment.GetChild(i).GetChild(j).gameObject.GetComponent<Renderer>().material.color.b;
                Debug.Log(name);
                if (name.Equals(environment.GetChild(i).name))
                {
                    environment.GetChild(i).GetChild(j).gameObject.GetComponent<Renderer>().material.color = new Color(red, green, blue, 0.25f);
                }
                else
                {
                    environment.GetChild(i).GetChild(j).gameObject.GetComponent<Renderer>().material.color = new Color(red, green, blue, 0.0f);
                }
            }
        }
        
    }
}
