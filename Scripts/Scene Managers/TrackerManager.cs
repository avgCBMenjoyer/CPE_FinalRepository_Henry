using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerManager
{
    public GameObject vuTracker;
    public GameObject sceneRef;
    public bool trackerActive;
    public string scenePrompt;
    public string helpPrompt;
    public TrackerManager()
    { 
    }

    public TrackerManager(GameObject newTracker, GameObject newScene, string newPrompt, string newHelp)
    {
        vuTracker = newTracker;
        sceneRef = newScene;
        scenePrompt = newPrompt;
        helpPrompt = newHelp;
        trackerActive = false;
    }
    public void activate()
    {
        trackerActive = true;
        vuTracker.SetActive(true);
    }
    public void deactivate()
    {
        trackerActive = false;
        vuTracker.SetActive(false);
    }

}
