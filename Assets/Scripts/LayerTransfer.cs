using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearScript : MonoBehaviour
{

    public GameObject[] layersBear;

    public void BearLayer()
    {
        GameObject.Find("_app").GetComponent<SwitchLayers>().layers = layersBear;
    }

    

}
