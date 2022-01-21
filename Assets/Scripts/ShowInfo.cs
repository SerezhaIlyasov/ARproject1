using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject plane;
    int clicId = 0;
    public void Start()
    {
        plane.SetActive(true);
    }
    public void OnMouseDown()
    {
        if (clicId % 2 == 1)
        {
            plane.SetActive(true);
        }
        else
        {
            plane.SetActive(false);
        }
        clicId++;
    }





}
