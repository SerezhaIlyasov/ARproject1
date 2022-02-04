using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerTransfer : MonoBehaviour
{

    public GameObject[] animalLayers;

    public void AnimalLayer()
    {
        GameObject.Find("_app").GetComponent<SwitchLayers>().layers = animalLayers;
    }

    

}
