using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    string name;
    public Player(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return this.name;
    }
}
