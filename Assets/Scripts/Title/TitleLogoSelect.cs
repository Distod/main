﻿using UnityEngine;
using System.Collections;

public class TitleLogoSelect : MonoBehaviour {

    public int number;

    public GameObject Select;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Select.GetComponent<TitleSelect>().number == number)
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
        else
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.4f);
        }
	}
}
