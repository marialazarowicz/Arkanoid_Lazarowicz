﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float minPos;
    [SerializeField] float maxPos;


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.Translate(horizontal, 0f, 0f);
        Vector2 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minPos, maxPos);
        transform.position = clampedPosition;
    }
}
