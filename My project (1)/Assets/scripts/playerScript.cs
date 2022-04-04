using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private Player thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = new Player("Mike");
    }

    // Update is called once per frame
    void Update()
    {
        print(thePlayer.getName());
    }
}
