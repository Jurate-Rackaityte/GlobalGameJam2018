using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour {

    public GameObject meteorite;
    public float Lenght = 25f;
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
    // Use this for initialization
    void Start () {
        Offset = Random.Range(0f, 99999f);
        sec = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (sec < Time.time)
        {
            //padidinu intensyvuma spawninimo
            amount -= intencity;
           // intencity += 0.0001f;

            for (int x = 0; x <= 25; x++)
            {
                if (PerlinNoice(x, 0) > amount)
                {
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
