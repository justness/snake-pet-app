
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
    public SpriteRenderer yeetin;
    public bool neutral;
    AudioSource ad;

    // Start is called before the first frame update
    void Start()
    {
        neutral = true;
        state = 0; //0 = still, 1 = left, 2 = right
        idle.enabled = true;
        vibin.enabled = false;
        yeetin.enabled = false;
        ad = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (neutral)
        {
            if (((transform.position.x <= -1.25) && (state == 1)) || ((transform.position.x >= 1.25) && (state == 2)))
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
                yeetin.enabled = false;
                speed = 0;
                if (timer == 100)
                {
                    state = Random.Range(0, 3);
                    timer = 0;
                }
                ad.enabled = false;
            }
            else if (state == 1)
            {
                idle.enabled = false;
                vibin.enabled = true;
                yeetin.enabled = false;
                speed = baseSpeed;
                rb.transform.Translate(-(transform.right * speed * Time.deltaTime));
                if (timer == 100)
                {
                    state = Random.Range(0, 3);
                    timer = 0;
                }
                ad.enabled = true;
            }
            else if (state == 2)
            {
                idle.enabled = false;
                vibin.enabled = true;
                yeetin.enabled = false;
                speed = baseSpeed;
                rb.transform.Translate(transform.right * speed * Time.deltaTime);
                if (timer == 100)
                {
                    state = Random.Range(0, 3);
                    timer = 0;
                }
                ad.enabled = true;
            }
            timer++;
        }
        if (state == 3)
        {
            idle.enabled = false;
            vibin.enabled = false;
            yeetin.enabled = true;
            speed = 0;
            if (timer == 100)
            {
                state = Random.Range(0, 3);
                timer = 0;
            }
            ad.enabled = false;
        }
    }
}
