using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{

    public GameObject alien1;
    public GameObject alien2;
    public float Lenght = 25f;
    public float period = 10f;

    private float position;
    private Vector3 pos;
    private float current;
    private float chance;
    // Use this for initialization
    void Start()
    {
        position = Random.Range(0f, Lenght);
        current = period;
    }

    // Update is called once per frame
    void Update()
    {
        if (current < Time.timeSinceLevelLoad)
        {
            pos = new Vector3(transform.position.x + position, transform.position.y, transform.position.z);
            chance = Random.Range(0f, 1f);
            if (chance > 0.5f)
                Instantiate(alien1, pos, Quaternion.identity);
            else Instantiate(alien2, pos, Quaternion.identity);
            position = Random.Range(0f, Lenght);
            current += period;
        }
    }
}
