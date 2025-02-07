using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);

        //Position of the camera is the position of the player
        //[x, y, z] = [x, y, z]

        //[x, y, z] = new Vector3(0, 0, -10)
    }
}
