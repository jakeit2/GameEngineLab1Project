using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;

public class TimelineZoneTrigger : MonoBehaviour
{
    public enum TriggerType
    {
        Once, Everytime,
    }

    public GameObject triggeringGameObject;
    public PlayableDirector director;
    public TriggerType triggerType;
    public UnityEvent OnDirectorPlay;
    public UnityEvent OnDirectorFinish;

    protected bool m_AleardyTriggered;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject != triggeringGameObject)
        return;

        if(triggerType == TriggerType.Once && m_AleardyTriggered)
        return;

        OnDirectorPlay.Invoke();
        director.Play();
        m_AleardyTriggered = true;
        Invoke("FinishInvoke", (float)director.duration);
    }

    void FinishInvoke()
    {
        OnDirectorFinish.Invoke();
    }
}
