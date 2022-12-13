using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printSetup : MonoBehaviour
{
    // Start is called before the first frame update

    
    public void OnClick_F()
    {
        MenuManager.OpenMenu(Menu.PRINTSENDING, gameObject);
    }

    // Update is called once per frame
    public void OnClick_B()
    {
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }
}
