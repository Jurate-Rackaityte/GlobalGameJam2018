using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consuming : MonoBehaviour {

    void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
            Debug.Log("triggered");
        }
}
