using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreditsScript : MonoBehaviour {
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
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
