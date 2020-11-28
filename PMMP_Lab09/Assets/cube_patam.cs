using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_patam : MonoBehaviour
{
    public GameObject player;
    public float FollowingSpeed;
    void Start()
    {
        FollowingSpeed = 5f;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, FollowingSpeed * Time.deltaTime);
    }
}
