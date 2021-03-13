using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour 
{
    public delegate void ClickAction();
    public static event ClickAction OnClix;


    void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            if(OnClix != null)
                OnClix();
        }
    }
}