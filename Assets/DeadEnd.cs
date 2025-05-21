using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEnd : MonoBehaviour
{
    [SerializeField]
    public GameObject DeadScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //DeadScreen.SetActive(true);
            Time.timeScale = 0f;
            collision.gameObject.GetComponent<Animator>().SetBool("isAlive", false);
        }
    }
}
