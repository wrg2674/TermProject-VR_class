using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cshFirePowder : MonoBehaviour
{
    public Transform firePos;
    public GameObject powder;
    public GameObject key;
    private float speed = 500.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(key == null)
        {
            input();
        }
        else
        {
            pinOut();
        }
        
    }
    void pinOut()
    {
        if (Input.GetMouseButtonDown(0))
        {
          
            // ȭ�鿡 �ִ� ��ǥ�� ���� ��ǥ��� ��ȯ��Ű�� �Լ�
            // �Ű����� : ���� ��ǥ��� �ٲ� ȭ���� ��ǥ
            Vector3 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition+new Vector3(0.0f,0.0f,1.0f));
            Debug.Log(clickPos);
            float rangeXL = key.transform.position.x - key.transform.localScale.x;
            float rangeXH = key.transform.position.x + key.transform.localScale.x;
            float rangeYL = key.transform.position.y - key.transform.localScale.y;
            float rangeYH = key.transform.position.y + key.transform.localScale.y;
            Debug.Log("rangeXL : " + rangeXL);
            Debug.Log("rangeXH : " + rangeXH);
            Debug.Log("rangeYL : " + rangeYL);
            Debug.Log("rangeYH : " + rangeYH);
            if (clickPos.x >= rangeXL && clickPos.x <= rangeXH && clickPos.y >= rangeYL && clickPos.y <= rangeYH)
            {
                Destroy(key);
            }
        }
    }
    public void input()
    {
        if (Input.GetKey(KeyCode.F))
        {
            fire(new Vector3 (0.0f, 0.0f,0.0f));
            fire(new Vector3(0.0f, 1.5f, 0.0f));
            fire(new Vector3(0.0f, -1.5f, 0.0f));
        }
    }
    public void fire(Vector3 v)
    {
        GameObject[] powders = new GameObject[9];
        for(int i=0; i < 4; i++)
        {
            powders[i] = GameObject.Instantiate(powder) as GameObject;
            powders[i].transform.position = firePos.position;
            powders[i].transform.rotation = firePos.rotation;
            powders[i].transform.Rotate(5.0f * (i / 2 - 1), 5.0f*(i%2-1), 0.0f);
            powders[i].transform.Rotate(v);
            powders[i].GetComponent<Rigidbody>().AddForce(powders[i].transform.forward * speed*Random.Range(0.5f,1.2f));
            Destroy(powders[i], 0.5f);
        }
        

    }
}
