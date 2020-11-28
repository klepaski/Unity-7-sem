﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_position : MonoBehaviour
{
    public float speed;

    void Start() {}
    void Update()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;
        float posZ = transform.position.z;

        transform.position = new Vector3(posX + Time.deltaTime, posY, posZ);
    }
}
