using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnCube : MonoBehaviour
{
    public float speed = 150f;
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
        
        SceneManager.LoadScene("MenuScene");
    }
}
