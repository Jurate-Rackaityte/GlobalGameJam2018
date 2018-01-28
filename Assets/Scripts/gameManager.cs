using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

    public int kebabCount;
    public int kebabGoal = 6;
    public float krakenDistance;
    public GameObject player;
    public GameObject kraken;

	// Use this for initialization
	void Start () {
        kebabCount = 0;
    }

    public void AddKebab()
    {
        kebabCount++;
        if (kebabCount == 2 || kebabCount == 4)
            player.GetComponent<playerController>().Evolve();
    }

    private void Update()
    {
        krakenDistance = player.transform.position.y - kraken.transform.position.y;

        if (krakenDistance <= 0)
            SceneManager.LoadScene(4);
        if (kebabCount >= kebabGoal)
        {
            if (player.GetComponent<playerController>().character > 0)
                SceneManager.LoadScene(5);
            else SceneManager.LoadScene(7);
        }
        Debug.Log("timeris: " + Time.time + "; kitas: " + Time.timeSinceLevelLoad);
    }

}
