using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMenu : MonoBehaviour
{
    public GameObject [] mainMenu;
    float animDuration = 0.5f;

    private void Start()
    {
        for (int i = 0; i < mainMenu.Length; i++)
        {
            mainMenu[i].SetActive(false);
        }
    }
    public void Show()
    {
        StartCoroutine(FadeIn());
    }


    public void Hide()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        for (float i = 0f; i <= 1f; i += Time.deltaTime / animDuration)
        {
            foreach (GameObject button in mainMenu)
            {
                button.GetComponent<Image>().color = Color.Lerp(Color.white, Color.clear, i);
            }
            yield return null;
        }
        foreach (GameObject button in mainMenu)
        {
            button.SetActive(false);
        }

    }

    IEnumerator FadeIn()
    {
        for (float i = 0f; i <= 1f; i += Time.deltaTime / animDuration)
        {
            foreach (GameObject buttons in mainMenu)
            {
                buttons.GetComponent<Image>().color = Color.Lerp(Color.clear, Color.white, i);
            }
            yield return null;
        }
        foreach (GameObject button in mainMenu)
        {
            button.SetActive(true);
        }
    }



}
