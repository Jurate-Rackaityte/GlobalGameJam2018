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
        Debug.Log("kebabai: " + kebabCount);
    }

    private void Update()
    {
        krakenDistance = player.transform.position.y - kraken.transform.position.y;
        if (krakenDistance <= 0)
            SceneManager.LoadScene(4);
        if (kebabCount >= kebabGoal)
            SceneManager.LoadScene(5);
    }

}
