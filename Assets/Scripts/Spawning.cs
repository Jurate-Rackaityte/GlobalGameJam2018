using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour {

    public GameObject meteorite;
    public GameObject meteorite1;
    public GameObject meteorite2;
    public GameObject meteorite3;
    public GameObject meteorite4;
    public GameObject meteorite5;
    public GameObject meteorite6;
    public GameObject meteorite7;
    public GameObject meteorite8;
    public GameObject meteorite9;
    public int Lenght = 25;
    public int width = 256;
    public int lenght = 256;
    public float scale = 10;
    public float delay = 2f; //in what period of seconds it spawns meteriotes
    public float amount = 0.5f;
    public float intencity = 0.001f;

    private float Offset = 100f;
    private int OffsetY = 0;
    private float sec;
    private Vector3 position;
    private int chance;
    // Use this for initialization
    void Start () {
        Offset = Random.Range(0f, 99999f);
        sec = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (sec < Time.timeSinceLevelLoad)
        {
            //padidinu intensyvuma spawninimo
            amount -= intencity;
           // intencity += 0.0001f;

            for (int x = 0; x <= Lenght; x++)
            {
                if (PerlinNoice(x, 0) > amount)
                {
                    chance = Random.Range(1,100);
                    if (chance < 30) meteorite = meteorite1;
                    else if (chance < 60) meteorite = meteorite2;
                    else if (chance < 66) meteorite = meteorite3;
                    else if (chance < 72) meteorite = meteorite4;
                    else if (chance < 78) meteorite = meteorite5;
                    else if (chance < 84) meteorite = meteorite6;
                    else if (chance < 90) meteorite = meteorite7;
                    else if (chance < 96) meteorite = meteorite8;
                    else meteorite = meteorite9;


                    position = new Vector3(transform.position.x + x, transform.position.y, transform.position.z);
                    Instantiate(meteorite, position, Quaternion.identity);

                }
            }
            OffsetY++;
            sec += delay;
        }
        
    }

    float PerlinNoice(int x, int y)
    {
        float xCoord = (float)x / width * scale + Offset;
        float yCoord = (float)y / lenght * scale + OffsetY;

        return Mathf.PerlinNoise(xCoord, yCoord);
    }

}
