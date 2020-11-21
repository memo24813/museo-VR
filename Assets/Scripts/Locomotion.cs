using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;
    
    public void TeleportPlayer(Vector3 newPosition)
    {
        // float step = 2*Time.deltaTime;
        // player.position = Vector3.MoveTowards(player.position,new Vector3(newPosition.x,player.position.y,newPosition.z),step);
        player.position = new Vector3(newPosition.x,player.position.y,newPosition.z);
        

    }
}
