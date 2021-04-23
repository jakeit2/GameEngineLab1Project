using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTrigger : MonoBehaviour
{
    public Story story;

    public void TriggerStory(){
        FindObjectOfType<StoryScriptSystem>().StartStory(story);
    }
}
