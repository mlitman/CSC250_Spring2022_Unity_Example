using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CORE.addRoomGO(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
