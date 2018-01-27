using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

    public float Speed;
    public bool boost;

    private Rigidbody2D body;
    private Vector2 up;
    private float currentSpeed;
    private bool boosted;
    private float boostTime;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
        up.Set(0, 2);
        currentSpeed = Speed;
    }
	
	// Update is called once per frame
	void Update () {

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
                currentSpeed = Speed;
            }
        }

        body.velocity = up * currentSpeed;
	}
}
