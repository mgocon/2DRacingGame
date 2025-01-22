using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        //kung kanino binigay, siya ito
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);

        //Position ni Camera = Position Player
        //[x, y, z] = [x, y, z]

        //[x, y, z] = new Vector3(0, 0, -10)
    }
}
