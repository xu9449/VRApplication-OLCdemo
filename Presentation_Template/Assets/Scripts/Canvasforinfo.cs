using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Canvasforinfo : MonoBehaviour
{
	public Transform canvas;
    public bool isShowing = false;
	void Start()
	{
		canvas.gameObject.SetActive(isShowing);
		Time.timeScale = 1;
		Cursor.visible = false;
	}

    public void Showit()
    {
		canvas.gameObject.SetActive(true);
		Time.timeScale = 1;
		Cursor.visible = true;

	}

   
    public void Hideit()
    {
		canvas.gameObject.SetActive(false);
		Time.timeScale = 1;
		Cursor.visible = false;
	}

	

    public void ChangeSatus()
	{
        if (isShowing == false) {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 1;
            Cursor.visible = !isShowing;
        }

        if (isShowing == true)
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            Cursor.visible = !isShowing;
        }
    } 

    
}
