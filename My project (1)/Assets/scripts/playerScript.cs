using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private Player thePlayer = new Player("Mike");
    private Rigidbody rb;
    public float speed = 20f;
    private int count = 0;

    // Start is called before the first frame update
    void Awake()
    {
        CORE.setPlayer(thePlayer);
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    public Player getPlayer()
    {
        return this.thePlayer;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("enemy"))
        {
            count++;
            if(count == 3)
            {
                this.thePlayer.addKill();
                print("Kill Count: " + this.thePlayer.getKillCount());
            }
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        //print(thePlayer.getName());
        if (Input.GetKeyDown("up"))
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown("down"))
        {
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            rb.velocity = Vector3.right * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.up * speed;
        }
        else if(Input.GetKeyDown("f"))
        {
            print("fire");
        }
    }
}
