using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class snekStats : MonoBehaviour
{
    public randomMove rm;
    private float width, height;
    public float hunger;
    private float full = 30.0f;
    public Image hungerBar;
    private Color original;

    // Start is called before the first frame update
    void Start()
    {
        hunger = full;
        width = Screen.width;
        height = Screen.height;
        original = hungerBar.color;
    }

    // Update is called once per frame
    void Update()
    {
        hungerBar.rectTransform.sizeDelta = new Vector2((hunger/full)*1000,50);
        hungerBar.color = new Color (original.r*(hunger/full),original.g*(hunger/full),original.b*(hunger/full),1);
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
