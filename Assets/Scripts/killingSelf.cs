using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killingSelf : MonoBehaviour {

    public float distance = 20f;

    private float sceneY;
    private GameObject scene;

    void Start ()
    {
        scene = GameObject.FindGameObjectWithTag("Scene");
    }

	// Update is called once per frame
	void Update () {
        sceneY = scene.transform.position.y;
        if (sceneY > this.transform.position.y + distance)
            Destroy(gameObject);
    }

}
