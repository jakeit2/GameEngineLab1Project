using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactablity : MonoBehaviour
{
    private GameObject triggeringNPC;
    private bool triggering;
    public bool canMove;
    private Rigidbody rb;
    public GameObject dialogueText;
    public GameObject npcText;
    // Update is called once per frame
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        
        if(triggering)
        {
            //dialogueText.SetActive(true);
            npcText.SetActive(true);
            //print("Player is triggering with " + triggeringNPC);
            if(Input.GetKeyDown(KeyCode.F))
            {
                dialogueText.SetActive(true);
                npcText.SetActive(false);
            }
        }else {
            npcText.SetActive(false);
            dialogueText.SetActive(false);
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            triggering = true;
            triggeringNPC = other.gameObject;
            //canMove = false;
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
