using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnofftute : MonoBehaviour
{

    public GameObject tutorialPanel;

    // Use this for initialization
    void Start()
    {

        if (PlayerPrefs.HasKey("HasRun"))
        {
            tutorialPanel.SetActive(false);

        }

        PlayerPrefs.SetInt("HasRun", 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
