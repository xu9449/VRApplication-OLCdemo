using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticule : MonoBehaviour
{
    public Pointer m_Pointer;
    public SpriteRenderer m_CircleRenderer;

    public Sprite m_OpenSPrite;
    public Sprite m_CloseSprite;

    private Camera m_Camera = null;
    // Start is called before the first frame update

    private void Awake()
    {
        m_Pointer.OnpointerUpdate += UpdateSprite;

        m_Camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(m_Camera.gameObject.transform);
    }

    private void OnDestroy()
    {
        m_Pointer.OnpointerUpdate -= UpdateSprite;
    }

    private void UpdateSprite(Vector3 point, GameObject hitObject)
    {
        transform.position = point;

        if(hitObject)
        {
            m_CircleRenderer.sprite = m_CloseSprite;
        } else
        {
            m_CircleRenderer.sprite = m_OpenSPrite;
        }
    }
}
