using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenuOnDeath : MonoBehaviour
{
    private Damageable damageable;

    private void Awake()
    {
        damageable = GetComponent<Damageable>();

        if (damageable == null)
        {
            Debug.LogError("ReturnToMainMenuOnDeath: No Damageable component found on this GameObject.");
        }
    }

    private void OnEnable()
    {
        if (damageable != null)
        {
            damageable.damageableDeath.AddListener(OnPlayerDeath);
        }
    }

    private void OnDisable()
    {
        if (damageable != null)
        {
            damageable.damageableDeath.RemoveListener(OnPlayerDeath);
        }
    }

    private void OnPlayerDeath()
    {
        // Start a coroutine that waits before loading the Main Menu
        StartCoroutine(ReturnAfterDelay(2f)); // Delay in seconds (you can change 2f to any value)
    }

    private IEnumerator ReturnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("MainMenu");
    }
}
