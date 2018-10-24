using UnityEngine;
using System.Collections;

public class tooth : MonoBehaviour
{
    public GameObject anatomyObject;
    public GameObject anatomyText;
    public GameObject endoObject;
    public GameObject endoText;
    public GameObject prosObject;
    public GameObject prosText;
    // public GameObject ageOfEruptionText;

    public void getHit(infomanager.InfoMode mode)
    {
        switch (mode)
        {
            case infomanager.InfoMode.anatomyMode:
                anatomyObject.SetActive(true);
                endoObject.SetActive(false);
                prosObject.SetActive(false);
                anatomyText.SetActive(true);
                endoText.SetActive(false);
                prosText.SetActive(false);
                // ageOfEruptionText.SetActive(false);
                break;
            case infomanager.InfoMode.endoMode:
                anatomyObject.SetActive(false);
                endoObject.SetActive(true);
                prosObject.SetActive(false);
                anatomyText.SetActive(false);
                endoText.SetActive(true);
                prosText.SetActive(false);
                // ageOfEruptionText.SetActive(false);
                break;
            case infomanager.InfoMode.prosMode:
                anatomyObject.SetActive(false);
                endoObject.SetActive(false);
                prosObject.SetActive(true);
                anatomyText.SetActive(false);
                endoText.SetActive(false);
                prosText.SetActive(true);
                // ageOfEruptionText.SetActive(false);
                break;

        }

    }

    public void closeInfo()
    {
        anatomyObject.SetActive(false);
        endoObject.SetActive(false);
        prosObject.SetActive(false);
        anatomyText.SetActive(false);
        endoText.SetActive(false);
        prosText.SetActive(false);
    }

    /* public void displayAgeOfEruption()
    {
        anatomyObject.SetActive(false);
        endoObject.SetActive(false);
        prosObject.SetActive(false);
        ageOfEruptionText.SetActive(true);
    }*/

}
