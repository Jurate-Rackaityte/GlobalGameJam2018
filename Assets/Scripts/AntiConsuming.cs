using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AntiConsuming : MonoBehaviour
{

    private GameObject player;
    private GameObject manager;

    private void Update()
    {
        transform.Rotate(-Vector3.forward, 100f * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(6);
    }
}
