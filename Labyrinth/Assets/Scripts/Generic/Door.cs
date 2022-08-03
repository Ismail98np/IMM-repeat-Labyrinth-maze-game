using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool open;

    public GameObject wonScreen;

    private void Update()
    {
        open = GameController.i.allKeysCollected;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (open)
        {
            wonScreen.SetActive(true);
        }
    }
}
