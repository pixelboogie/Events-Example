using UnityEngine;
using System.Collections;

public class TurnColorScript : MonoBehaviour 
{
    void OnEnable()
    {
        EventManager.OnClix += TurnColor;
    }


    void OnDisable()
    {
        EventManager.OnClix -= TurnColor;
    }


    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }
}