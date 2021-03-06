﻿using UnityEngine;

public class CubeClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        R = new System.Random();
        Force = 0f;
        CountForce = false;
    }

    private System.Random R;
    public float Force;
    private bool CountForce;

    void Update()
    {
        Force += CountForce ? 3000 * Time.deltaTime : 0;
    }
    private void OnMouseDown()
    {
        CountForce = true;
    }
    private void OnMouseUp()
    {
        transform.GetComponent<Rigidbody>().AddForce(R.Next((int)-Force, (int)Force), R.Next((int)-Force, (int)Force), R.Next((int)-Force, (int)Force));
        Force = 0f;
        CountForce = false;
        transform.GetComponent<MeshRenderer>().material.color = new Color(((float)R.Next(100) / 100), ((float)R.Next(100) / 100), ((float)R.Next(100) / 100));
    }
}
