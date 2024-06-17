using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death1 : MonoBehaviour
{
    Control pc;
    
    private void Start()
    {
        pc = Object.FindFirstObjectByType<Control>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pc.resetPosition();
        }
    }
 
}
