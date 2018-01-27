using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class charSelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayEdge()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("Char", -1);
    }

    public void PlayOppay()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("Char", 1);
    }

}
