using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;
    public Transform target5;

    public float speed;
    // Update is called once per frame

    private void Update()
    {
        
    }
    public void MovetoTarget1()
    {
        float step = speed * Time.deltaTime;
        transform.position = target1.position;
    }

    public void MovetoTarget2()
    {
        float step = speed * Time.deltaTime;
        transform.position = target2.position;
    }
    public void MovetoTarget3()
    {
        float step = speed * Time.deltaTime;
        transform.position = target3.position;
    }
    public void MovetoTarget4()
    {
        float step = speed * Time.deltaTime;
        transform.position = target4.position;
    }
    public void MovetoTarget5()
    {
        float step = speed * Time.deltaTime;
        transform.position = target5.position;
    }
}
