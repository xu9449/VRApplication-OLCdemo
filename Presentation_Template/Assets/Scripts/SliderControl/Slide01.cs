using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide01 : MonoBehaviour
{
    public nextbutton buttonmove;
    public int SlideIndex;
    // Start is called before the first frame update
    void Start()
    {
        buttonmove = GameObject.Find("Slide_Carrousel").GetComponent<nextbutton>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void OnVRTriggerDown()
    //{
    //    buttonmove.Move(SlideIndex);
    //}
}
