using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    private Player thePlayer;

    public Room()
    {
        this.thePlayer = null;
    }

    public void setPlayer(Player p)
    {
        this.thePlayer = p;
    }

    public Player getPlayer()
    {
        return this.thePlayer;
    }
}
