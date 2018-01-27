using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    // public AudioClip clickSound;
    //public AudioSource source;
    // Use this for initialization
    void Start () {
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

        SceneManager.LoadScene(3);
    }

    public void Exit()
    {
       // source.PlayOneShot(clickSound);
        print("Bye bye!");
        Application.Quit();
    }

    public void Credits()
    {
        // source.PlayOneShot(clickSound);
        print("Crediiiiits!!!");
        SceneManager.LoadScene(2);
    }
}
