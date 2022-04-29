using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    private Room currentRoom;

    public Enemy()
    {
        this.currentRoom = null;
    }

    public void setRoom(Room r)
    {
        this.currentRoom = r;
    }

    public Room getRoom()
    {
        return this.currentRoom;
    }
}
