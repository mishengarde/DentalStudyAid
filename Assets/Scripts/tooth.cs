using UnityEngine;
using System.Collections;

public class tooth : MonoBehaviour
{
    public GameObject anatomyObject;
    public GameObject endoObject;
    public GameObject prosObject;
    public GameObject ageOfEruptionText;

    public void getHit(infomanager.InfoMode mode)
    {
        switch (mode)
        {
            case infomanager.InfoMode.anatomyMode:
                anatomyObject.SetActive(true);
                endoObject.SetActive(false);
                prosObject.SetActive(false);
                ageOfEruptionText.SetActive(false);
                break;
            case infomanager.InfoMode.endoMode:
                anatomyObject.SetActive(false);
                endoObject.SetActive(true);
                prosObject.SetActive(false);
                ageOfEruptionText.SetActive(false);
                break;
            case infomanager.InfoMode.prosMode:
                anatomyObject.SetActive(false);
                endoObject.SetActive(false);
                prosObject.SetActive(true);
                ageOfEruptionText.SetActive(false);
                break;

        }

    }

    public void displayAgeOfEruption()
    {
        anatomyObject.SetActive(false);
        endoObject.SetActive(false);
        prosObject.SetActive(false);
        ageOfEruptionText.SetActive(true);
    }

}
