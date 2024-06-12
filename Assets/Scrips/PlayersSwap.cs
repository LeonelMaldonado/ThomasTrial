using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersSwap : MonoBehaviour
{
    public PlayerController playerController;
    public PlayerController player2Controller;
    private bool player1Active = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SwitchPlayer();
        }
    }
    public void SwitchPlayer()
    {
        if (player1Active)
        {
            playerController.enabled = false;
            player2Controller.enabled = true;
            player1Active = false;
        }
        else
        {
            playerController.enabled = true;
            player2Controller.enabled = false;
            player1Active = true;
        }
    }
}
