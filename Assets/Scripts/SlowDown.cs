using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour {

    private GameObject player;
    private GameObject scene;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<playerController>().SlowDown();

        scene = GameObject.FindGameObjectWithTag("Scene");
        scene.GetComponent<moving>().SlowDown();

        Debug.Log("colision " + Time.time + "; " + gameObject);

        Destroy(gameObject);
    }
}
