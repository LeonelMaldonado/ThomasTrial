using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersSwap : MonoBehaviour
{
    public Control playerController;
    public Control player2Controller;
    private bool playerActive = true;

    public bool chnYes = false;
    void Start()
    {
        playerController.enabled = false;
        player2Controller.enabled = true;

        playerController.enabled = true;
        player2Controller.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && chnYes == true)
        {
            SwitchPlayer();
        }
    }
    public void SwitchPlayer()
    {
        if (playerActive)
        {
            playerController.enabled = false;
            player2Controller.enabled = true;
            playerActive = false;
        }
        else
        {
            playerController.enabled = true;
            player2Controller.enabled = false;
            playerActive = true;
        }
    }
}
