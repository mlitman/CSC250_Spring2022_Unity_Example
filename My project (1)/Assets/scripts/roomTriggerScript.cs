using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            print("Player Entered room " + this.gameObject.ToString());
        }
        else if(other.gameObject.tag.Equals("enemy"))
        {
            print("Enemy Entered room " + this.gameObject.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
