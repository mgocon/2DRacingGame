using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] bool hasPowerUp;
    [SerializeField] private float powerUpMoveSpeed = 20f; //Speed when power-up is active
    [SerializeField] private float defaultMoveSpeed = 10f;
    [SerializeField] Color32 hasPowerUpColor = new Color32(90, 140, 12, 255);
    [SerializeField] Color32 defaultColor = new Color32(255, 255, 255, 255);

    SpriteRenderer spriteRenderer;
    private Driver driver;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PowerUp" && !hasPowerUp)
        {
            Debug.Log("Power up has been picked up");

            driver = FindObjectOfType<Driver>();

            if (driver != null)
            {
                spriteRenderer.color = hasPowerUpColor;
                driver.SetMoveSpeed(powerUpMoveSpeed);
                hasPowerUp = true;
                StartCoroutine(RemovePowerUpAfterDelay(5f));
            }

            Destroy(other.gameObject);
        }
    }

    private IEnumerator RemovePowerUpAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (driver != null)
        {
            driver.SetMoveSpeed(defaultMoveSpeed);
        }
        if (spriteRenderer != null)
        {
            spriteRenderer.color = defaultColor;
        }

        hasPowerUp = false;
        Debug.Log("Speed boost effect has worn off");
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
