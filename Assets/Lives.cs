﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Text lives;
    // Start is called before the first frame update
    void Start()
    {
        lives.text = GameManager.lives.ToString();
    }

    
}
