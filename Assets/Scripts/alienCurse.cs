using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienCurse : MonoBehaviour {

    private GameObject player;

    void OnTriggerEnter2D(Collider2D collision)
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<playerController>().inverted = true;
    }
}
