using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public int kebabCount;

	// Use this for initialization
	void Start () {
        kebabCount = 0;
	}

    public void AddKebab()
    {
        kebabCount++;
        Debug.Log("kebabai: " + kebabCount);
    }

    public void RemoveKebab()
    {
        kebabCount--;
    }
}
