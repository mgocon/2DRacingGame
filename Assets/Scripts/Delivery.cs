using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] public bool hasPackage;
    [SerializeField] public Color32 hasPackageColor = new Color32(142, 85, 250, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

    SpriteRenderer spriteRenderer;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package has been picked up.");
            hasPackage = true;
            // Destroy(other.gameObject, 1);
            //1 second before the object disappears
            Destroy(other.gameObject);
            spriteRenderer.color = hasPackageColor;
        }

        else if (other.tag == "Package" && hasPackage)
        {
            Debug.Log("You already have a package in hand.");
        }


        if (other.gameObject.tag == "Customer" && !hasPackage)
        {
            Debug.Log("Failed to deliver, you don't have the package.");
        }
        else if (other.gameObject.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered to cusomer.");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }

    //!Option in order to not pass through the customer, NOTE: NOT WORKING!!
    // void OnCollisionEnter2D(Collision2D other)
    // {
    //     if(other.gameObject.tag == "Customer" && !hasPackage)
    //     {
    //         Debug.Log("Failed to deliver, you don't have the package.");
    //     }
    //     else if(other.gameObject.tag == "Customer" && hasPackage)
    //     {
    //         Debug.Log("Package delivered to customer.");
    //         hasPackage = false;
    //         spriteRenderer.color = noPackageColor;
    //     }
    // }

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
