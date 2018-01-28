using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KebabSpawning : MonoBehaviour {

    public GameObject kebab;
    public GameObject evilKebab;
    public float Lenght = 25f;
    public float period = 10f;
    public float firstRatio = 1f;
    public float addingRatio = 0.05f;

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
            if (chance > firstRatio)
                Instantiate(evilKebab, pos, Quaternion.identity);
            else Instantiate(kebab, pos, Quaternion.identity);
            firstRatio -= addingRatio;
            position = Random.Range(0f, Lenght);
            current += period;
        }

    }

}
