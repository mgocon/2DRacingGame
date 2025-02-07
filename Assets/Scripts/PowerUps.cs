using System.Collections;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] bool hasPowerUp;
    [SerializeField] private float powerUpMoveSpeed = 20f; // Speed when power-up is active
    [SerializeField] private float defaultMoveSpeed = 8f; // Default speed

    private Driver driver; // Reference to the driver script

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PowerUp" && !hasPowerUp)
        {
            Debug.Log("Power up has been picked up");

            driver = FindObjectOfType<Driver>(); 

            if (driver != null)
            {
                driver.SetMoveSpeed(powerUpMoveSpeed); // Apply speed boost
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
            driver.SetMoveSpeed(defaultMoveSpeed); // Revert to default speed
        }

        hasPowerUp = false;
        Debug.Log("Speed boost effect has worn off");
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialization, if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Any ongoing logic, if needed
    }
}
