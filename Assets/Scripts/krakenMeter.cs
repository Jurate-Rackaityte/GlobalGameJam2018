using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class krakenMeter : MonoBehaviour {

    public GameObject master;
    public GameObject kracken;
    public GameObject player;
    public GameObject floorLevel;
    public float MaxDistance = 30f;
    public GameObject oppai;
    public GameObject edgy;

    private float distance;
    private float yLocation;
    private float xLocation;
    private float floor;
    private int charac;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        floor = floorLevel.transform.position.y;
        xLocation = kracken.transform.position.x;
        distance = master.GetComponent<gameManager>().krakenDistance;
        charac = player.GetComponent<playerController>().character;
        if (charac > 0)
        {
            oppai.SetActive(true);
            edgy.SetActive(false);
        }
        else
        {
            oppai.SetActive(false);
            edgy.SetActive(true);
        }
        yLocation = 6.5f - ((distance / MaxDistance) * 4.5f);
        if (yLocation > 0)
            kracken.transform.position = new Vector2(xLocation, floor + yLocation);
        else kracken.transform.position = new Vector2(xLocation, floor);
    }
}
