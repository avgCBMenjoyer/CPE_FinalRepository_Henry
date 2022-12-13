using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MenuManager
{
    public static GameObject printCanvas, mainMenu, washer, dryer, printer, scanner, printSetup= GameObject.Find("PrintSetupHost"), printSend= GameObject.Find("PrintSenderHost");

    public static List<GameObject> targetList = SceneList.targetArray;



    public static bool IsInit { get; private set; }

    //Init initialises the Scene objects
    public static void Init()
    {
        mainMenu = GameObject.Find("MainMenu");
        washer = GameObject.Find("WashScenes");
        dryer = GameObject.Find("DryScenes");
        printer = GameObject.Find("Scenes");
        scanner = GameObject.Find("ScanScenes");
        printSetup = GameObject.Find("PrintSetupHost");
        printSend = GameObject.Find("PrintSenderHost");
        printCanvas = GameObject.Find("ARCanvas");
        Debug.LogWarning("boop: " + printSend.name);

        IsInit = true;
    }

    public static void OpenMenu(Menu menu, GameObject callingMenu)
    {
        if (!IsInit)
        {
            Init();
        }

        //Each menu is activated based on the enum passed by a button call
        switch (menu)
        {
            case Menu.MAIN_MENU:
                mainMenu.SetActive(true);
                break;
            case Menu.WASHING:
                washer.SetActive(true);
                break;
            case Menu.DRYING:
                dryer.SetActive(true);
                break;
            case Menu.PRINTING:    //Since the Print option has an extra guide menu, that extra menu has to activate the print canvas
                printer.SetActive(true);
                printCanvas.SetActive(true);
                break;
            case Menu.SCANNING:
                scanner.SetActive(true);
                break;
            //These buttons are for the extra print menus
            case Menu.PRINTSETUP:
                printSetup.SetActive(true);
                break;
            case Menu.PRINTSENDING:
                printSend.SetActive(true);
                break;

        }

        callingMenu.SetActive(false);
    }
    //Used to deactivate all the Vuforia motion targets (since too many activated would cause it to not work)
    public static void resetTargets(GameObject activateObj)
    {
        for (int i = 0; i < targetList.Count; i++)
        {
            if(targetList[i].name == activateObj.name)
            {
                targetList[i].SetActive(true);
            }
            else
            {
                targetList[i].SetActive(false);
            }
            
        }
    }
}
