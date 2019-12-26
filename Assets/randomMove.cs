
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMove : MonoBehaviour
{
    public int state;
    public float baseSpeed = 1;
    float speed;
    float timer = 0;
    public Rigidbody2D rb;
    public SpriteRenderer idle;
    public SpriteRenderer vibin;

    // Start is called before the first frame update
    void Start()
    {
        state = 0; //0 = still, 1 = left, 2 = right
        idle.enabled = true;
        vibin.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (((transform.position.x <= -1.25)&&(state==1)) || ((transform.position.x >= 1.25)&&(state==2)))
        {
            Debug.Log("wall");
            state = 0;
            if (timer == 100)
            {
                state = Random.Range(0, 3);
                timer = 0;
            }
        }

        if (state == 0)
        {
            idle.enabled = true;
            vibin.enabled = false;
            speed = 0;
            if (timer == 100)
            {
                state = Random.Range(0, 3);
                timer = 0;
            }
        }
        else if (state == 1)
        {
            idle.enabled = false;
            vibin.enabled = true;
            speed = baseSpeed;
            rb.transform.Translate(-(transform.right * speed * Time.deltaTime));
            if (timer == 100)
            {
                state = Random.Range(0,3);
                timer = 0;
            }
        }
        else if (state == 2)
        {
            idle.enabled = false;
            vibin.enabled = true;
            speed = baseSpeed;
            rb.transform.Translate(transform.right * speed * Time.deltaTime);
            if (timer == 100)
            {
                state = Random.Range(0, 3);
                timer = 0;
            }
        }
        timer++;
    }
}
