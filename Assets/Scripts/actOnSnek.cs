using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actOnSnek : MonoBehaviour
{
    public snekStats stats;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (stats.hunger < stats.getFull())
            {
                stats.hunger = stats.getFull();
                Debug.Log("Fed to full!");
            }
        }
    }
}
