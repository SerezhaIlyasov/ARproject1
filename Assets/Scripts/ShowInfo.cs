using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject plane;
    int clicId = 0;
    public void Start()
    {
        plane.SetActive(false);
        SetActiveWithChildren(true);
    }
    public void OnMouseDown()
    {
        if (clicId % 2 == 0)
        {
            plane.SetActive(true);
        }
        else
        {
            plane.SetActive(false);
        }
        clicId++;
    }

    void SetActiveWithChildren(bool isActive)
    {
        GameObject[] childrens = plane.GetComponentsInChildren<GameObject>();
        foreach (GameObject child in childrens)
        {
            child.SetActive(isActive);
        }


    }






}
