using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;
    private Vector3 offsetRotation;

    void Start()
    {
        offset = new Vector3(0,3,-8);
    }

    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
