using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public GameObject dead;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")||collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            
        }
        if (collision.CompareTag("Player"))
        {
            dead.SetActive(true);
        }
    }
}
