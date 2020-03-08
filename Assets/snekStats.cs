using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snekStats : MonoBehaviour
{
    public randomMove rm;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void angerSnake()
    {
        rm.state = 3;
    }
}
