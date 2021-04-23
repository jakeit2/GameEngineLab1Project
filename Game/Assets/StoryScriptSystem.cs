using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryScriptSystem : MonoBehaviour
{
    public Text storyText;
    public GameObject thestoryText;
    public GameObject openLevel;
    public GameObject startStory;

    private Queue<string> sentences;

    void Start(){
        sentences = new Queue<string>();
        openLevel.SetActive(false);
    }

    public void StartStory(Story story){
        storyText.text = story.story;
        sentences.Clear();

        foreach (string sentence in story.sentences){
            sentences.Enqueue(sentence);
        }
        startStory.SetActive(false);
        openLevel.SetActive(true);
        DisplayNextSentence();
    }

    public void DisplayNextSentence(){
        if(sentences.Count == 0){
            EndStory();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence){
        storyText.text = "";
        foreach(char letter in sentence.ToCharArray()){
            storyText.text += letter;
            yield return null;
        }
    }

    public void EndStory(){
        Debug.Log("End of Story");
        SceneManager.LoadScene("TutorialWorld");
    }

}
