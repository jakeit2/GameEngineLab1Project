﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactablity : MonoBehaviour
{
    private GameObject triggeringNPC;
    private bool triggering;

    public GameObject npcText;
    // Update is called once per frame
    void Update()
    {
        if(triggering)
        {
            npcText.SetActive(true);
            print("Player is triggering with " + triggeringNPC);
            if(Input.GetKeyDown(KeyCode.E))
            {
                triggering = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            triggering = true;
            triggeringNPC = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "NPC")
        {
            triggering = false;
            triggeringNPC = null;
        }
    }
}
