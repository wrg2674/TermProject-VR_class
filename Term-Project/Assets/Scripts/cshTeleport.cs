using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshTeleport : MonoBehaviour
{
    public GameObject inDoor;
    public GameObject outDoor;

    private Vector3 distance = new Vector3(5.0f, 0.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        teleport(other.gameObject);
    }
    public void teleport(GameObject player)
    {
        
        if(player.tag != "Player")
        {
            return;
        }
        if(this.gameObject == inDoor)
        {
            player.transform.position = outDoor.transform.position - distance;
            player.GetComponentInChildren<cshFirePowder>().changeIsInDoor();
        }
        else
        {
            player.transform.position = inDoor.transform.position + distance;
            player.GetComponentInChildren<cshFirePowder>().changeIsInDoor();
        }
        
    }
}
