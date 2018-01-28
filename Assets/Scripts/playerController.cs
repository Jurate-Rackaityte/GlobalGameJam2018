using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float speed;
    public bool boost;
    public float slowness = 0.5f;
    public bool inverted = false;
    public float invertedTime = 10f;
    public int character;
    public float barrier = 10f;
    public AudioClip edgySong;
    public AudioClip oppaiSong;
    public AudioSource audioSource;

    private Rigidbody2D body;
    private bool boosted = false;
    private float boostTime = 0f;
    private float currentSpeed;
    private float alienTime;
    private int stage = 1; //evolution stage
    private float totalTime;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        character = PlayerPrefs.GetInt("Char");
        body = GetComponent<Rigidbody2D>();
        currentSpeed = speed;
        anim = GetComponent<Animator>();

        if (character == 1)
        {
            stage = 1;
            audioSource.clip = oppaiSong;
            audioSource.Play();
            audioSource.loop = true;
        }  
        else Edgy();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (transform.position.x <= -barrier)
        {
            transform.position = new Vector2(-barrier, transform.position.y);
        }
        else if (transform.position.x >= barrier)
        {
            transform.position = new Vector2(barrier, transform.position.y);
        }

        if (inverted)
        {
            moveHorizontal *= -1;
            inverted = false;
            alienTime = Time.time + invertedTime;
        }
        if (alienTime > Time.time)
        {
            moveHorizontal *= -1;
        }

        if (boost && !boosted)
        {
            boostTime = Time.time;
            boosted = true;
        }
        if (boost && boosted)
        {
            currentSpeed = speed;
            if (Time.time - boostTime <= 2)
                currentSpeed *= 1.003f;
            else if (Time.time - boostTime < 5)
                currentSpeed /= 1.002f;
            else
            {
                boosted = false;
                boost = false;
                currentSpeed = speed;
            }
        }

        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        //{
        //    totalTime = Time.deltaTime * moveHorizontal; // this will increase the totalTime as long as you hold down "whatever" key }
        //}
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        //{
        //    totalTime = 0f; //this just resets the totaltime on the keyup 
        //}

        Vector2 movement = new Vector2(moveHorizontal, 1);
        body.velocity = movement * currentSpeed;
    }

    public void SlowDown()
    {
        currentSpeed -= slowness;
    }

    public void Edgy()
    {
        stage = -1;
        audioSource.clip = edgySong;
        audioSource.Play();
        audioSource.loop = true;
        anim.SetBool("edgy1", true);
    }

    public void Evolve()
    {
        if (stage > 0)
        {
            if (stage == 1)
            {
                anim.SetBool("oppai2", true);
                stage = 2;
            }
            else if (stage == 2)
            {
                anim.SetBool("oppai3", true);
                stage = 3;
            }

        }
        else if (stage < 0)
        {
            if (stage == -1)
            {
                anim.SetBool("edgy2", true);
                stage = -2;
            }
            else if (stage == -2)
            {
                anim.SetBool("edgy3", true);
                stage = -3;
            }
        }
    }


}