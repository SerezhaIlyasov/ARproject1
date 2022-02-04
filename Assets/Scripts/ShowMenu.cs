using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{
    public GameObject [] mainMenu;

    private void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            mainMenu[i].SetActive(false);
        }
    }
    public void Show()
    {
        for (int i = 0; i < 2; i++)
        {
            mainMenu[i].SetActive(true);
        }
    }


    public void Hide()
    {
        for (int i = 0; i < 2; i++)
        {
            mainMenu[i].SetActive(false);
        }
    }





}
