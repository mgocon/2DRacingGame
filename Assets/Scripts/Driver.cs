using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Find which controls your movement
        // transform.Rotate(0, rotationSpeed, 0);
        // transform.Translate(0, 0, directionSpeed);
        // Debug.Log(Input.GetAxis("Horizontal"));
        // Debug.Log(Input.GetAxis("Vertical"));

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * steerSpeed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(0, y, 0);
        transform.Rotate(0, 0, x);
    }

    public void SetMoveSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
    }
}
