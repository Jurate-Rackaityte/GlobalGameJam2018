using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrakenMove : MonoBehaviour {

    public float Speed = 7f;
    public GameObject player;

    private Rigidbody2D body;
    private Vector2 up;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
        up.Set(0, 1);
    }
	
	// Update is called once per frame
	void Update () {
        body.velocity = up * Speed;

        if (player.transform.position.y <= this.transform.position.y)
            Debug.Log("Kraken: ate you!");


    }
}
