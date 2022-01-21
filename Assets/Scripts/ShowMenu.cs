using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{
    public GameObject mainMenu;
    private void Start()
    {
        mainMenu.SetActive(false);
    }


    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
    }





}
