using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeout : MonoBehaviour
{
    public GameObject objectToFade;

    public void fadeOut()
    {
        StartCoroutine(doFade());
    }

    IEnumerator doFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 1;
            yield return null;
        }
        canvasGroup.interactable = false;
        objectToFade.SetActive(false);
        yield return null;
    }
}
