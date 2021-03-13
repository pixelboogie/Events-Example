using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour 
{
    void OnEnable()
    {
        EventManager.OnClix += Teleport;
    }


    void OnDisable()
    {
        EventManager.OnClix -= Teleport;
    }


    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}