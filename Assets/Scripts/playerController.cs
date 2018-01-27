using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float speed;
    public bool boost;
    public float slowness = 0.5f;
    public bool inverted = false;
    public float invertedTime = 10f;

    private Rigidbody2D body;
    private bool boosted = false;
    private float boostTime = 0f;
    private float currentSpeed;
    private float alienTime;
    private int stage = 1; //evolution stage
    Animator anim;


    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        currentSpeed = speed;

       // anim = GetComponent<Animator>();

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (inverted)
        {
            moveHorizontal *= -1;
            inverted = false;
            alienTime = Time.time + invertedTime;
        }
        if (alienTime > Time.time)
        {
            moveHorizontal *= -1;
        }

        if (boost && !boosted)
        {
            boostTime = Time.time;
            boosted = true;
        }
        if (boost && boosted)
        {
            currentSpeed = speed;
            if (Time.time - boostTime <= 2)
                currentSpeed *= 1.003f;
            else if (Time.time - boostTime < 5)
                currentSpeed /= 1.002f;
            else
            {
                boosted = false;
                boost = false;
                currentSpeed = speed;
            }
        }
        Vector2 movement = new Vector2(moveHorizontal, 1);
        body.velocity = movement * currentSpeed;
    }

    public void SlowDown()
    {
        currentSpeed -= slowness;
    }

    public void Evolve()
    {
        if (stage > 0)
        {
            //if (stage == 1)

        }
    }


}