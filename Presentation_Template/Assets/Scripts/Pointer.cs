using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pointer : MonoBehaviour
{
    public float m_Distance = 10.0f;
    public LineRenderer m_LineRenderer = null;
    public LayerMask m_EverthignMask = 0;
    public LayerMask m_InteractableMask = 0;
    public UnityAction<Vector3, GameObject> OnpointerUpdate = null;

    public GameObject go;
    public GameObject empty;

    private Transform m_CurrentOrigion = null;
    private GameObject m_currentObject = null;
    

    private void Awake()
    {
        PlayerEvents.OnControllerSource += UpdateOrigion;
        PlayerEvents.OnTouchpadDown += ProcessTouchpadDown;
    }

    private void Start()
    {
        SetLineColor();

        empty = new GameObject();
        go = empty;
    }

    private void OnDestroy()
    {
        PlayerEvents.OnControllerSource -= UpdateOrigion;
        PlayerEvents.OnTouchpadDown -= ProcessTouchpadDown;
    }

    private void Update()
    {
        RaycastHit hit;
        transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote);

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider != null)
            {

                if (go != hit.collider.gameObject)
                {

                    go.transform.SendMessage("OnVRExit");
                    go = hit.transform.gameObject;


                    go.transform.SendMessage("OnVREnter");
                    Debug.Log("On VR Raycast Enter");
                }

                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                {
                    go.transform.SendMessage("OnVRTriggerDown");


                }
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    go.transform.SendMessage("OnVRButtonOneDown");
                }
                if (OVRInput.GetDown(OVRInput.Button.Two))
                {

                }
            }
        }
        else
        {
            if (go != null)
            {
                go.transform.SendMessage("OnVRExit");
                go = empty;
            }
        }


        Vector3 hitPoint = UpdateLine();

        m_currentObject = UpdatePointerStatus();

        if (OnpointerUpdate != null)
            OnpointerUpdate(hitPoint, m_currentObject);

    }
    

    private Vector3 UpdateLine()
    {
        // Create ray
        RaycastHit hit = CreateRaycast(m_EverthignMask);

        // Derfault end
        Vector3 endPosition = m_CurrentOrigion.position + (m_CurrentOrigion.forward * m_Distance);

        // Check hit
        if (hit.collider != null)
            endPosition = hit.point;

        // Set position
        m_LineRenderer.SetPosition(0, m_CurrentOrigion.position);
        m_LineRenderer.SetPosition(1, endPosition);

        return endPosition;
    }


    private void UpdateOrigion(OVRInput.Controller controller, GameObject controllerObject)
    {
        // Set Origin of Pointer
        m_CurrentOrigion = controllerObject.transform;

        // Set Is the laser visible?
        if (controller == OVRInput.Controller.Touchpad)
        {
            m_LineRenderer.enabled = false;
        }
        else
        {
            m_LineRenderer.enabled = true;
        }
    }

    private GameObject UpdatePointerStatus() 
    {
        // Create ray
        RaycastHit hit = CreateRaycast(m_InteractableMask);

        // Check hit
        if (hit.collider)
            return hit.collider.gameObject;
        // return
        return null;
    }

    


    private RaycastHit CreateRaycast(int layer) 
    {
        RaycastHit hit;
        Ray ray = new Ray(m_CurrentOrigion.position, m_CurrentOrigion.forward);
        Physics.Raycast(ray, out hit, m_Distance, layer);
        return hit;
    }

    private void SetLineColor()
    {
        if (!m_LineRenderer)
            return;
        Color endColor =Color.white;
        endColor.a = 0.0f;
    }
    private void ProcessTouchpadDown()
    {
        if (!m_currentObject)
            return;

        Interactable interactable = m_currentObject.GetComponent<Interactable>();
        interactable.Press();
    }
}
