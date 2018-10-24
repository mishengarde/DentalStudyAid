using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Togglescript : MonoBehaviour
{

    public GameObject toggleObject;

    public void OnChangeValue()
    {
        bool onoffSwitch = gameObject.GetComponent<Toggle>().isOn;
        if (onoffSwitch)
        {
            toggleObject.SetActive(true);
        }
        else
        {
            toggleObject.SetActive(false);
        }

    }
}