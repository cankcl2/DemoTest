using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public int theScore = 0;
    public GUIStyle scoreStyle;

    private void OnGUI()
    {
        GUI.Label(new Rect(230, 10, 180, 65), "Score : " + theScore , scoreStyle);
    }
}
