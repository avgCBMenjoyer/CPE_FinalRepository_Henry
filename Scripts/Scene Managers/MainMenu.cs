using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject arCamera, targetList, printCanvas, washCanvas, dryCanvas, printSend, printSetupCanvas, printSendCanvas;
    void Start()
    {
        //Initialises the objects on startup
        arCamera = GameObject.Find("ARCamera");
        targetList = GameObject.Find("Targets");
        printCanvas = GameObject.Find("ARCanvas");
        washCanvas = GameObject.Find("WashCanvas");
        dryCanvas = GameObject.Find("DryCanvas");
        printSetupCanvas = GameObject.Find("PrintSetupHost");
        printSendCanvas = GameObject.Find("PrintSenderHost");
        MenuManager.Init();
        
        arCamera.SetActive(false);
        targetList.SetActive(false);
        printCanvas.SetActive(false);
    }

    //Each function is a call which the respective menu button will call upon
    //For each call, the MenuManager's OpenMenu function is called, passing the appropriate enum and the Main Menu object
    public void OnClick_Washer()
    {
        deactivateCanvas();
        activateComp();
        washCanvas.SetActive(true);
        MenuManager.OpenMenu(Menu.WASHING, gameObject);
        
    }

    public void OnClick_Dryer()
    {
        
        deactivateCanvas();
        activateComp();
        dryCanvas.SetActive(true);
        MenuManager.OpenMenu(Menu.DRYING, gameObject);
    }

    public void OnClick_Printer()
    {
        deactivateCanvas();
        activateComp();
        printSetupCanvas.SetActive(true);
        MenuManager.OpenMenu(Menu.PRINTSETUP, gameObject);
        
    }

    public void OnClick_Scanner()
    {
        MenuManager.OpenMenu(Menu.SCANNING, gameObject);
        activateComp();
    }

    void activateComp() //Activates the AR components
    {
        arCamera.SetActive(true);
        targetList.SetActive(true);
        
    }

    void deactivateCanvas()  //Resets all the other canvasses
    {
        printCanvas.SetActive(false);
        washCanvas.SetActive(false);
        dryCanvas.SetActive(false);
        printSetupCanvas.SetActive(false);
        printSendCanvas.SetActive(false);
        
    }


}
