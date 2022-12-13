using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ManageScenes : MonoBehaviour
{
    public static List<TrackerManager> sceneArray = new List<TrackerManager>();
    public static List<TrackerManager> washArray = SceneList.washArray;
    public static List<TrackerManager> printArray = SceneList.printArray;
    public static List<TrackerManager> dryArray = SceneList.dryArray;
    public static List<TrackerManager> scanArray = SceneList.scanArray;

    [SerializeField]
    public TMP_Text userText, helpText;
    public GameObject helpButton, helpImage;

    public bool buttonPressed=false;
    public bool IsActive = false;
    public  int sceneCount, printCount, washCount, dryCount, scanCount, currentScene;

    // Start is called before the first frame update
    public void Initialize()
    {

        sceneCount = 0;
        printCount = SceneList.printCount;
        washCount = SceneList.washCount;
        dryCount = SceneList.dryCount;
        sceneArray = null;
        sceneArray = new List<TrackerManager>();
        string objectName = gameObject.name;
        Debug.Log(objectName);
        /*Checks which main object the particular instance of the script is in 
         and assigns the scene array based on that*/
        if (objectName == "Scenes")
        {
            sceneArray = printArray;
            sceneCount = printCount;
        }
        else if(objectName == "WashScenes")
        {
            sceneArray = washArray;
            sceneCount = washCount;
        }
        else if(objectName == "DryScenes")
        {
            sceneArray = dryArray;
            sceneCount = dryCount;
        }
        else if(objectName == "ScanScenes")
        {
            sceneArray = scanArray;
            sceneCount = scanCount;
        }
        //initialises the Vuforia tracker and scene objects, and sets this script instance to active
        Debug.Log(sceneCount);
        currentScene = 0;
        MenuManager.resetTargets(sceneArray[currentScene].vuTracker);
        sceneArray[currentScene].trackerActive = true;
        userText.text = sceneArray[currentScene].scenePrompt;
        IsActive = true;
        helpImage.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (IsActive)  //Each Scene Holder has a copy of this script. It will only run the Update function if it is declared active
        {
            for (int i = 0; i < sceneCount; i++)
            {
                //If the current scene is set to Active & the Vuforia tracker is detected, then activate the 3D object
                if (sceneArray[i].trackerActive && sceneArray[i].vuTracker.transform.GetChild(0).transform.gameObject.activeSelf)
                {
                    sceneArray[i].sceneRef.SetActive(true);
                    sceneArray[i].sceneRef.transform.position = sceneArray[i].vuTracker.transform.position;
                }
                else
                {
                    sceneArray[i].sceneRef.SetActive(false);
                }

            }
            //Make the help button visible if the current scene has a help prompt
            if (sceneArray[currentScene].helpPrompt != "~HUTHTHO~")
            {
                helpButton.SetActive(true);
            }
            else
            {
                helpButton.SetActive(false);
            }
            if (helpImage.activeSelf)
            {
                helpText.text = sceneArray[currentScene].helpPrompt;
            }


            
        }
    }
    


    public void OnClick_Forward()
    {
        Debug.Log(sceneCount);

        //If the current scene is not before the last And is active, move to the next scene
        if (currentScene < sceneCount - 1 && IsActive)
        {
            currentScene++;
            Debug.Log("Current Scene: " + currentScene);
            sceneArray[currentScene - 1].deactivate();
            sceneArray[currentScene].activate();
            userText.text = sceneArray[currentScene].scenePrompt;

        }
        else //return to main menu
        {
            IsActive = false;
            MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
        }

    }

    public void OnClick_Back()
    {
        //If the current scene is not just after the first And is active, move back a scene
        if (currentScene > 0 && IsActive)
        {
            Debug.Log("Current Scene: " + currentScene);
            sceneArray[currentScene].deactivate();
            currentScene--;
            sceneArray[currentScene].activate();
            userText.text = sceneArray[currentScene].scenePrompt;
        }
        else //move back to the main menu
        {
            IsActive = false;
            MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
        }
    }

   

}


