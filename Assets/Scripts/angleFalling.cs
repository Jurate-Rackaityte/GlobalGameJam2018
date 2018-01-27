using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angleFalling : MonoBehaviour {

    public float OffsetSpeed = 100f; 

    private Rigidbody2D body;
    private float customRand;

    void Start()
    {
        customRand = Random.Range(-1f, 1f);
    }

	// Update is called once per frame
	void Update () {
        
        body = gameObject.GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(customRand * OffsetSpeed * Time.deltaTime, 0);
    }
}
