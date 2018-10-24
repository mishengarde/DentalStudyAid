// Saves screenshot as PNG file.
using UnityEngine;
using System.Collections;
using System.IO;

public class screenshot : MonoBehaviour
{

    public void UploadPNG()
    {
        StartCoroutine(ActuallySave());

    }

    public IEnumerator ActuallySave()
    {
        yield return new WaitForEndOfFrame();

        // Create a texture the size of the screen, RGB24 format
        int width = Screen.width;
        int height = Screen.height;
        Texture2D tex = new Texture2D(width, height, TextureFormat.RGB24, false);

        // Read screen contents into the texture
        tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        tex.Apply();

        // Encode texture into PNG
        byte[] bytes = tex.EncodeToPNG();
        Object.Destroy(tex);

        string filePath = Application.persistentDataPath + "/DenteractScreenshots";

        if (File.Exists(filePath) == false)
        {
            Directory.CreateDirectory(filePath);
        }

        // For testing purposes, also write to a file in the project folder

        File.WriteAllBytes(filePath + "/SavedScreen.png", bytes);
    }
}