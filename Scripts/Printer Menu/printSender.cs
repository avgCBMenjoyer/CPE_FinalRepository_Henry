using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printSender : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick_F()
    {
        MenuManager.OpenMenu(Menu.PRINTING, gameObject);
    }

    // Update is called once per frame
    public void OnClick_B()
    {
        MenuManager.OpenMenu(Menu.PRINTSETUP, gameObject);
    }
}
