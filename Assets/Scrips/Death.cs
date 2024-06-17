using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    PlayerController pc1;
    
    private void Start()
    {
        pc1 = Object.FindFirstObjectByType<PlayerController>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pc1.resetPosition();
        }
    }
 
}
