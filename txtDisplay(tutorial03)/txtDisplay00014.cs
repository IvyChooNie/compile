﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class txtDisplay00014 : MonoBehaviour
{
    public static string textDisplay00014 = "";

    Text txt;

    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = textDisplay00014;
    }
    }
