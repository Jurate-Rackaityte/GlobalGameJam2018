using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kebabMeter : MonoBehaviour {

    public GameObject master;
    public GameObject kebab1;
    public GameObject kebab2;
    public GameObject kebab3;
    public GameObject kebab4;
    public GameObject kebab5;
    public GameObject kebab6;

    private int kebabAmount = 0;
    private int oldAmount = 0;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        kebabAmount = master.GetComponent<gameManager>().kebabCount;

        if (kebabAmount > oldAmount)
        {
            if (kebabAmount == 1)
                kebab1.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            if (kebabAmount == 2)
                kebab2.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            if (kebabAmount == 3)
                kebab3.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            if (kebabAmount == 4)
                kebab4.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            if (kebabAmount == 5)
                kebab5.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            if (kebabAmount == 6)
                kebab6.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            oldAmount++;
        }
	}
}
