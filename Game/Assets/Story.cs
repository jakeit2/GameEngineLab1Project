using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Story : MonoBehaviour
{
    public string story;
    [TextArea(3,5)]
    public string[] sentences;
}
