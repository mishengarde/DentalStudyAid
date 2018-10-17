using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infomanager : MonoBehaviour
{

    public GameObject anatomyInfo;
    public GameObject prosInfo;
    public GameObject endoInfo;

    // Use this for initialization
    void Start()
    {

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
                //Create ray & cast out to distance of 200
                if (Physics.Raycast(ray, out hit, 200))
                {
                    //if successful hit, check tag
                    if (hit.transform.tag == "tooth33")
                    {
                        Debug.Log("Touched!");
                    }
                }
            }
        }
    }
}
