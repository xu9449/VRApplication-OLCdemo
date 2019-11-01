using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectShow : MonoBehaviour
{
    public GameObject go;
    public bool ObjectStatus;

    //private void Start()
    //{
    //    go.SetActive(ObjectStatus);
    //}
    

    public void Showit()
    {
        go.SetActive(true);
        Time.timeScale = 1;
        Cursor.visible = true;
    }

    public void Disappear()
    {
        go.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
    }
}
