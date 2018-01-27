﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consuming : MonoBehaviour {

    private GameObject player;
    private GameObject manager;

    private void Update()
    {
        transform.Rotate(Vector3.forward, 100f * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<playerController>().Evolve();

        manager = GameObject.FindGameObjectWithTag("GameController");
        manager.GetComponent<gameManager>().AddKebab();
        Destroy(gameObject);
    }
}
