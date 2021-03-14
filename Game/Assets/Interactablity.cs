using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactablity : MonoBehaviour
{
    private GameObject triggeringNPC;
    private bool triggering;

    public GameObject dialogueText;
    public GameObject npcText;
    // Update is called once per frame

    void Update()
    {
        dialogueText.SetActive(true);
        if(triggering)
        {
            
            npcText.SetActive(true);
            //print("Player is triggering with " + triggeringNPC);
            if(Input.GetKeyDown(KeyCode.F))
            {

                triggering = false;
                npcText.SetActive(false);
                dialogueText.SetActive(true);
            }
        }else {
            npcText.SetActive(false);
            
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
