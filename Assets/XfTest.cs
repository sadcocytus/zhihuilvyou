using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XfTest : MonoBehaviour {

    private string showResult = "";

    void OnGUI()

    {

        if (GUILayout.Button("startRecognizer", GUILayout.Height(100)))
        {

            AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

            AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");

            jo.Call("startSpeechListener");

        }

        GUILayout.TextArea(showResult, GUILayout.Width(200));

    }



    public void LogXfMessage(string recognizerResult)

    {

        showResult += recognizerResult;

    }
}
