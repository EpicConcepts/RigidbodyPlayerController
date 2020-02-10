using UnityEngine;

public class CustomStats : MonoBehaviour {

    private float deltaTime = 0.0f;

    private int quality;
    private string qualityLevel;

    private int resolution;
    private string resolutionLevel;

    private int vsync;
    private string vsyncLevel;

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        quality = PlayerPrefs.GetInt("Quality");

        if (quality == 0)
        {
            qualityLevel = "Low";
        }
        else if (quality == 1)
        {
            qualityLevel = "Medium";
        }
        else if (quality == 2)
        {
            qualityLevel = "High";
        }
        else if (quality == 3)
        {
            qualityLevel = "Very High";
        }

        resolution = PlayerPrefs.GetInt("Resolution");

        if (resolution == 0)
        {
            resolutionLevel = "1920 x 1080";
        }
        else if (resolution == 1)
        {
            resolutionLevel = "1600 x 900";
        }
        else if (resolution == 2)
        {
            resolutionLevel = "1366 x 768";
        }
        else if (resolution == 3)
        {
            resolutionLevel = "1280 x 720";
        }
        else if (resolution == 4)
        {
            resolutionLevel = "1024 x 576";
        }

        vsync = PlayerPrefs.GetInt("VSync");

        if (vsync == 0)
        {
            vsyncLevel = "Off";
        }
        else if (vsync == 1)
        {
            vsyncLevel = "On";
        }
    }

    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect1 = new Rect(10, 10, w, h * 2 / 100);
        Rect rect2 = new Rect(10, 35, w, h * 2 / 100);
        Rect rect3 = new Rect(10, 60, w, h * 2 / 100);
        Rect rect4 = new Rect(10, 85, w, h * 2 / 100);

        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 100;
        style.normal.textColor = new Color(0.0f, 0.0f, 0.0f, 1.0f);
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        string qualityString = "Quality = " + qualityLevel;
        string resolutionString = "Resolution = " + resolutionLevel;
        string vsyncString = "Vsync = " + vsyncLevel;

        GUI.Label(rect1, text, style);
        GUI.Label(rect2, qualityString, style);
        GUI.Label(rect3, resolutionString, style);
        GUI.Label(rect4, vsyncString, style);
    }
}
