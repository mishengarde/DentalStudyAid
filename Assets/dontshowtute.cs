using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontshowtute : MonoBehaviour
{

    public GameObject tutePanel;

    public void ToggleTute()
    {
        if (!PlayerPrefs.HasKey("HasRunBefore"))
        {
            PlayerPrefs.SetInt("HasRunBefore", 1);
        }

        SetToggleState();
    }

    private void SetToggleState()
    {
        if (!PlayerPrefs.HasKey("HasRunBefore"))
        {
            tutePanel.SetActive(true);
        }
        else
        {
            tutePanel.SetActive(false);
        }
    }
}
