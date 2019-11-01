using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class PlayButton : MonoBehaviour
{
    public VideoPlayer x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnVRTriggerDown()
    {
        x.Play();
    }
}
