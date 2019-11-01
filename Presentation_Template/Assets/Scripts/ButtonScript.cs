using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private bool opened;
    public Vector3 openPosition, closedPosition;
    // Start is called before the first frame update
    void Start()
    {
        opened = false;
        closedPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!opened)
        {
            transform.position = Vector3.MoveTowards(transform.position, closedPosition, Time.deltaTime * 5f);
        }

        if(opened)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                openPosition, Time.deltaTime * 5f);
        }
    }

    void OnVRTriggerDown()
    {
        
    }
}
