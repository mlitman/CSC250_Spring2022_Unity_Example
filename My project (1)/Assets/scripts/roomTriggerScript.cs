using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomTriggerScript : MonoBehaviour
{
    private Room thisRoom;
    public GameObject roomGO;

    // Start is called before the first frame update
    
    void Awake()
    {
        //print("*************** Room trigger has started *************");
        CORE.addRoomTriggerGO(this.gameObject);
        this.thisRoom = new Room(this.gameObject);
        CORE.addRoom(this.thisRoom);
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(this.roomGO);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            this.thisRoom.setPlayer(CORE.getPlayer()); //lets the new room know about the player
            //print("Player now in room: " + this.thisRoom);
        }
        else if(other.gameObject.tag.Equals("enemy"))
        {
            this.thisRoom.setEnemy(CORE.getEnemy());
            //print("Enemy Entered room " + this.gameObject.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
