using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private string name;
    private int killCount;

    public Player(string name)
    {
        this.name = name;
        this.killCount = 0;
    }

    public void addKill()
    {
        this.killCount++;
    }

    public int getKillCount()
    {
        return this.killCount;
    }

    public string getName()
    {
        return this.name;
    }
}
