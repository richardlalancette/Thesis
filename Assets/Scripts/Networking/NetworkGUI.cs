﻿using UnityEngine;
using System.Collections;

public class NetworkGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 40), "Stats"))
        {
            NetworkManager.Stats();
        }
    }
}