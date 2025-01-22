using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("You crashed!");
        //!Is Trigger is off, you won't pass through the object

        //?Square
        Debug.Log(other.gameObject.name);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("You passed through the object");
        //!Remember to activate is trigger

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //*NOTES:
    //100 pixel is in 1 grid
}
