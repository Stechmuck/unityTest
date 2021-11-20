using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileUtilsScript : MonoBehaviour {
	float deltaTime = 0.0f;
 
 public Text txt;
 
	void Update()
	{
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
		
		updateFPS();
	}

    void updateFPS()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 50;
        style.normal.textColor = new Color(1.0f, 1.0f, 0.0f, 1.0f);
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps @ {2:0.} entities)", msec, fps, AddInstance.n);
		txt.text = text;
    }
}
