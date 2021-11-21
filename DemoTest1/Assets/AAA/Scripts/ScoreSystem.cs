using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public int theScore = 0;

    private void OnGUI()
    {
        GUI.Label(new Rect(230, 10, 100, 20), "Score : " + theScore);
    }
}
