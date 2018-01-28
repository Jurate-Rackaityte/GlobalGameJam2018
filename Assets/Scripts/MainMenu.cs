using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    public AudioClip clickSound;
    public AudioSource source;
    // Use this for initialization
    void Start () {
        source.clip = clickSound;
    }

    // Update is called once per frame
    void Update () {

		
	}

    private void Awake()
    {
        
    }

    public void PlayGame()
    {
        // source.PlayOneShot(clickSound);
        source.Play();
        SceneManager.LoadScene(3);
    }

    public void Exit()
    {
        // source.PlayOneShot(clickSound);
        source.Play();
        Application.Quit();
    }

    public void Credits()
    {
        source.Play();
        // source.PlayOneShot(clickSound);
        SceneManager.LoadScene(2);
    }
}
