﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeveloperWorkBench : MonoBehaviour
{
    public enum GameMode
    {
        Side_Scroller = 1,
        Topdown = 2
    };

    public GameMode gameMode;

    private float dist;
    private Vector3 MouseStart;
    private Vector3 derp;

    void Start()
    {
        dist = transform.position.z;  // Distance camera is above map
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            MouseStart = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
            MouseStart = Camera.main.ScreenToWorldPoint(MouseStart);
            MouseStart.z = transform.position.z;

        }
        else if (Input.GetMouseButton(2))
        {
            var MouseMove = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
            MouseMove = Camera.main.ScreenToWorldPoint(MouseMove);
            MouseMove.z = transform.position.z;
            transform.position = transform.position - (MouseMove - MouseStart);
        }
    }

}
