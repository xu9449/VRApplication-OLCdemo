using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextbutton : MonoBehaviour
{
    public float rotAmount;
    public Vector3  destEuler;
    public  float speed;
    public Vector3 currEuler;
    public GameObject go;
    
    // Start is called before the first frame update
    void Start()
    {
        //currEuler = destEuler;
        //transform.eulerAngles = destEuler;
        
    }

    // Update is called once per frame

    //public void NextSlide()
    //{
    //    destEuler.y -= rotAmount;
    //    currEuler = Vector3.Lerp(currEuler, destEuler, Time.deltaTime * speed);
    //    transform.eulerAngles = currEuler;
    //}

    //public void LastSlide()
    //{
    //    destEuler.y += rotAmount;
    //    currEuler = Vector3.Lerp(currEuler, destEuler, Time.deltaTime * speed);
    //    transform.eulerAngles = currEuler;
    //}
    

    //public void Move(int SlideIndex)
    //{
    //    destEuler.y = rotAmount * SlideIndex ;
    //    currEuler = Vector3.Lerp(currEuler, destEuler, Time.deltaTime * speed);
    //    transform.eulerAngles = currEuler;
    //}

    public void ObejectRotationNext(GameObject go)
    {
        destEuler.y = destEuler.y - rotAmount;
        go.transform.rotation = Quaternion.Euler(new Vector3(0, destEuler.y, 0));
        
    }

    public void ObejectRotationLast(GameObject go)
    {
        destEuler.y = destEuler.y + rotAmount;
        go.transform.rotation = Quaternion.Euler(new Vector3(0, destEuler.y, 0));

    }
}
