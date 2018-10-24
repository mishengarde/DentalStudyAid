using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class infomanager : MonoBehaviour
{
    public enum InfoMode
    {
        anatomyMode, prosMode, endoMode, none

    }

    public InfoMode infoMode;

    public GameObject anatomyInfo;
    public GameObject prosInfo;
    public GameObject endoInfo;

    public tooth currentTooth;

    /*public GameObject teethParent;
    public tooth[] teeth;
    public GameObject paedsText;*/

    // Use this for initialization
    void Start()
    {
        // teeth = teethParent.GetComponentsInChildren<tooth>();

    }

    // Update is called once per frame
    void Update()
    {

        //Detect touch for this frame
        if (infoMode != InfoMode.none)
        {
            if (Input.touchCount > 0)
            {


                Debug.Log("Theres a touch!");

                var touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {

                    if (EventSystem.current.IsPointerOverGameObject(0) == false)
                    {
                        Debug.Log("The tap missed any UI elements");
                        if (currentTooth != null)
                        {
                            currentTooth.closeInfo();
                        }

                    }
                    else
                    {
                        Debug.Log("The tap hit a UI element {0}", EventSystem.current.currentSelectedGameObject);
                    }

                    Debug.Log("The touch just began!");

                    Debug.DrawRay(Camera.main.ScreenToWorldPoint(touch.position), Camera.main.transform.forward, Color.blue, 1.0f);

                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);
                    //Create ray & cast out to distance of 200m
                    if (Physics.Raycast(ray, out hit, 200))
                    {
                        Debug.Log("The ray hit something!");

                        //if successful hit, check tag
                        if (hit.transform.tag == "tooth")
                        {
                            Debug.Log("It was a tooth - {0}", hit.collider.gameObject);

                            currentTooth = hit.collider.GetComponent<tooth>();

                            currentTooth.getHit(infoMode);

                        }
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

    public void tapMissedUIElements()
    {
        currentTooth.closeInfo();

    }



    /* public void changeModetoPaeds()
    {
        foreach (tooth T in teeth)
        {
            T.displayAgeOfEruption();
        }
    } */
}
