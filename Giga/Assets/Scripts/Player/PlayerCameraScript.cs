using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraScript : MonoBehaviour
{

    //Target for which the camera will follow.
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            throw new System.Exception("PlayerCameraScript - target variable not provided.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}
