using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selection : MonoBehaviour {
    public AudioClip clickSound;
    public AudioSource source;
    // Use this for initialization
    void Start () {
        source.clip = clickSound;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Back()
    {
        source.Play();
        SceneManager.LoadScene(0);
    }

    public void PlayEdge()
    {
        source.Play();
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("Char", -1);
    }

    public void PlayOppay()
    {
        source.Play();
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("Char", 1);
    }

}
