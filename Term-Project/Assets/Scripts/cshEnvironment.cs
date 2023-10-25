using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class cshEnvironment : MonoBehaviour, IPointerClickHandler
{
    public Transform environment;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            GameObject button = eventData.pointerEnter;
            MyButton myButton = new MyButton(button.name);
            myButton.doWork(environment);
        }
    }
}
