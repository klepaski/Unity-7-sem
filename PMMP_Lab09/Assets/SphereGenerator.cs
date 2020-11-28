using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    void Start()
    {
        render = gameObject.GetComponent<MeshRenderer>();
        minX = render.bounds.min.x;
        maxX = render.bounds.max.x;
        minZ = render.bounds.min.z;
        maxZ = render.bounds.max.z;
        newY = gameObject.transform.position.y + 15;
    }

    MeshRenderer render;
    float minX, minZ, maxX, maxZ, newX, newZ, newY;

    void Update()
    {
        newX = Random.Range(minX, maxX);
        newZ = Random.Range(minZ, maxZ);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(newX, newY, newZ);
            cube.AddComponent<Rigidbody>();
        }
        if (Input.GetMouseButtonDown(0))
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = new Vector3(newX, newY, newZ);
            sphere.AddComponent<Rigidbody>();
        }
    }
}
