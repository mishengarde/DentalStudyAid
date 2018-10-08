using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TakeScreenshot : MonoBehaviour
{
    private int screenshotCount = 0;

    // Check for screenshot key each frame
    void Update()
    {
        // take screenshot on touch

        if (Input.touches.Length > 0)
        {
            string screenshotFilename;
            do
            {
                screenshotCount++;
                screenshotFilename = "screenshot" + screenshotCount + ".png";

            } while (System.IO.File.Exists(screenshotFilename));

            //  audio.Play();

            ScreenCapture.CaptureScreenshot(screenshotFilename);
        }

    }
}
