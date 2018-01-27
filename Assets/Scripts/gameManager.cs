using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public int kebabCount;
    public int krakenCount = 100;

	// Use this for initialization
	void Start () {
        kebabCount = 0;
	}

    public void AddKraken(int score)
    {
        krakenCount += score;
    }

    public void AddKebab()
    {
        kebabCount++;
        Debug.Log("kebabai: " + kebabCount);
    }

}
