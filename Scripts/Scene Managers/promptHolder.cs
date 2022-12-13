using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class promptHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject thisTracker;
    public string thisPrompt;
    public string thisHelp = "~HUTHTHO~";

    
    public static int sceneCount;

    public static List<GameObject> trackerArray = new List<GameObject>();
    public static List<string> promptArray = new List<string>();
    public static List<string> helpArray = new List<string>();
    public static List<string> sceneLabelArr = new List<string>();

    void Start()
    {
        trackerArray.Add(thisTracker);
        promptArray.Add(thisPrompt);
        helpArray.Add(thisHelp);
        sceneLabelArr.Add(gameObject.name);
        //Debug.LogError("Ligma: " + gameObject.name);
        //Debug.LogError("Butt: " + thisPrompt);
        
        sceneCount++;

        
    }
}
