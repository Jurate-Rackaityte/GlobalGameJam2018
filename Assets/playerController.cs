using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float speed;
    public bool boost;

    private Rigidbody2D body;
    private bool boosted = false;
    private float boostTime = 0f;
    private float currentSpeed;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        currentSpeed = speed;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKey("l"))
            boost = true;

        if (boost && !boosted)
        {
            boostTime = Time.time;
            boosted = true;
        }
        if (boost && boosted)
        {
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
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        body.velocity = movement * currentSpeed;


        Debug.Log("movement: " + body.velocity + "    " + Time.time + "   " + (Time.time - boostTime));
    }
}