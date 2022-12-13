using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneList : MonoBehaviour
{

    public static List<TrackerManager> sceneArray = new List<TrackerManager>();
    public static List<TrackerManager> washArray = new List<TrackerManager>();
    public static List<TrackerManager> printArray = new List<TrackerManager>();
    public static List<TrackerManager> scanArray = new List<TrackerManager>();
    public static List<TrackerManager> dryArray = new List<TrackerManager>();
    public static List<GameObject> targetArray = new List<GameObject>();
   

    public static int printCount, washCount, scanCount, dryCount;


    // Start is called before the first frame update
    void Start()
    {
        //Generate all the lists and update the counts manually
        updateTargets();
        
        printUpdate();
        dryUpdate();
        washUpdate();
        scanUpdate();
        printCount = 3;
        dryCount = 5;
        washCount = 4;
        scanCount = 5;

        

    }


    //THE FOLLOWING CODE WAS AN ATTEMPT AT AUTOMATION BY GATHERING SCENE DATA. DUE TO ISSUES WITH UNITY, IT WAS SCRAPPED.
    /*
    public promptHolder uwu;
    void updateList(string myPath, ref int myCount, ref List<TrackerManager> myArray )
    {
        GameObject targetList = GameObject.Find(myPath);
        foreach (Transform child in targetList.transform)
        {
            int index = 0;
            for (int i=0; i<promptHolder.sceneCount; i++)
            {
                Debug.LogError("UwU: "+promptHolder.sceneLabelArr[i]);
                if(child.name == promptHolder.sceneLabelArr[i])
                {
                    index = i;
                    break;
                }
            }
            TrackerManager temp = new TrackerManager(promptHolder.trackerArray[index], child.gameObject, promptHolder.promptArray[index], promptHolder.helpArray[index]);
            myArray.Add(temp);
            myCount++;
        }

    }
    */
    void updateTargets()
    {
        GameObject targetList = GameObject.Find("Targets");
        foreach (Transform child in targetList.transform)
        {
            targetArray.Add(child.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void printUpdate()
    {
        TrackerManager temp;
        temp = new TrackerManager(GameObject.Find("TargetOne"), GameObject.Find("Scenes/Scene1"), "Scan your NYU ID", "Scan the ID by itself");
        printArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("TargetTwo"), GameObject.Find("Scenes/Scene2"), "Select your document", "~HUTHTHO~");
        printArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("TargetTwo"), GameObject.Find("Scenes/Scene3"), "Press Print to Start", "Check for low paper if it failed");
        printArray.Add(temp);


    }

    void dryUpdate()
    {
        TrackerManager temp;
        temp = new TrackerManager(GameObject.Find("Targets/TargetFour"), GameObject.Find("DryScenes/DryScene1"), "Remove the lint filter and clean it", "Filter on the bottom of opening");
        dryArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("Targets/TargetFive"), GameObject.Find("DryScenes/DryScene2"), "Remove the drain tank and empty it", "~HUTHTHO~");
        dryArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("Targets/TargetFour"), GameObject.Find("DryScenes/DryScene3"), "Place your clothes into the dryer", "~HUTHTHO~");
        dryArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("Targets/TargetFive"), GameObject.Find("DryScenes/DryScene4"), "Select a setting", "Select based on the material");
        dryArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("Targets/TargetFive"), GameObject.Find("DryScenes/DryScene5"), "Start the dryer by holding your finger", "~HUTHTHO~");
        dryArray.Add(temp);
    }

    void washUpdate()
    {
        TrackerManager temp;
        temp = new TrackerManager(GameObject.Find("Targets/TargetSeven"), GameObject.Find("WashScenes/WashScene1"), "Check your pockets before placing clothes", "Slightly pull on handle when closing");
        washArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("Targets/TargetSix"), GameObject.Find("WashScenes/WashScene2"), "Open Soap Drawer and put laundry detergent", "2 scoops of powder, fill middle for liquid");
        washArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("Targets/TargetSix"), GameObject.Find("WashScenes/WashScene3"), "Choose a setting", "Time in hours and mins is displayed");
        washArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("Targets/TargetSix"), GameObject.Find("WashScenes/WashScene4"), "Start the machine", "Press the door in slightly if it fails");
        washArray.Add(temp);
    }

    void scanUpdate()
    {
        TrackerManager temp;
        temp = new TrackerManager(GameObject.Find("TargetOne"), GameObject.Find("ScanScenes/ScanScene1"), "Scan your NYU ID", "Scan the ID by itself");
        scanArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("TargetTwo"), GameObject.Find("ScanScenes/ScanScene2"), "Click on the Scan option", "~HUTHTHO~");
        scanArray.Add(temp);
        
        temp = new TrackerManager(GameObject.Find("TargetTwo"), GameObject.Find("ScanScenes/ScanScene3"), "Lift the Scanner Bed lid", "~HUTHTHO~");
        scanArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("TargetThree"), GameObject.Find("ScanScenes/ScanScene4"), "Place the document face down here", "~HUTHTHO~");
        scanArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("TargetTwo"), GameObject.Find("ScanScenes/ScanScene5"), "Select ScanToEmail", "Check positioning if it fails");
        scanArray.Add(temp);
        temp = new TrackerManager(GameObject.Find("TargetTwo"), GameObject.Find("ScanScenes/ScanScene6"), "Press Scan for multiple pages and press end when done", "~HUTHTHO~");
    }


    


}
