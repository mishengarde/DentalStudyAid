using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infomanager : MonoBehaviour
{
    public enum InfoMode
    {
        anatomyMode, prosMode, endoMode

    }

    public InfoMode infoMode;

    public GameObject anatomyInfo;
    public GameObject prosInfo;
    public GameObject endoInfo;
    public GameObject teethParent;
    public tooth[] teeth;
    public GameObject paedsText;

    // Use this for initialization
    void Start()
    {
        teeth = teethParent.GetComponentsInChildren<tooth>();

    }

    // Update is called once per frame
    void Update()
    {
        //Detect touch for this frame
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                //Create ray & cast out to distance of 1m
                if (Physics.Raycast(ray, out hit, 1))
                {
                    //if successful hit, check tag
                    if (hit.transform.tag == "tooth")
                    {
                        hit.collider.GetComponent<tooth>().getHit(infoMode);

                    }
                }
            }
        }
    }

    public void changeModeToAnatomy()
    {
        infoMode = InfoMode.anatomyMode;
        anatomyInfo.SetActive(true);
        endoInfo.SetActive(false);
        prosInfo.SetActive(false);
    }

    public void changeModeToEndo()
    {
        infoMode = InfoMode.endoMode;
        anatomyInfo.SetActive(false);
        endoInfo.SetActive(true);
        prosInfo.SetActive(false);
    }

    public void changeModeToPros()
    {
        infoMode = InfoMode.prosMode;
        anatomyInfo.SetActive(false);
        endoInfo.SetActive(false);
        prosInfo.SetActive(true);
    }

    public void changeModetoPaeds()
    {
        foreach (tooth T in teeth)
        {
            T.displayAgeOfEruption();
        }
    }
}
