using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLayers : MonoBehaviour
{
    public GameObject[] layers;
    int layerId = 0;
    private void Start()
    {
        foreach (GameObject layer in layers)
        {
            layer.SetActive(false);
        }
        layers[0].SetActive(true);
    }

    public void buttonUp()
    {
       
        layers[layerId].SetActive(false);

        if (layerId == layers.Length - 1)
        {
            layerId = 0;
        }
        else
        {
            layerId++;
        }
        layers[layerId].SetActive(true);
    }
    public void buttonDown()
    {

        layers[layerId].SetActive(false);

        if (layerId == 0)
        {
            layerId = layers.Length - 1;
        }
        else
        {
            layerId--;
        }
        layers[layerId].SetActive(true);
    }
}
