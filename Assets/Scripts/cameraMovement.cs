using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {

    public GameObject up;
    public GameObject downn;
    public float speed = 5f;

    private float destination;
    private Rigidbody2D body;

    // Use this for initialization
    void Start () {
        destination = downn.transform.position.y;
        body = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		if (destination == downn.transform.position.y && downn.transform.position.y < this.transform.position.y)
        {
            body.velocity = new Vector2(0, speed) * Time.deltaTime * -1;
        }
	}
}
