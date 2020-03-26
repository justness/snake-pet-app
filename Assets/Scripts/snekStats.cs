using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snekStats : MonoBehaviour
{
    public randomMove rm;
    private float width, height;
    public float hunger;
    private float full = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        hunger = full;
        width = Screen.width;
        height = Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        if (hunger <= 0)
        {
            rm.state = 3;
        }
        else
        {
            hunger = hunger - Time.deltaTime;
        }
    }

    public void angerSnake()
    {
        rm.state = 3;
    }

    public float getFull()
    {
        return full;
    }
}
