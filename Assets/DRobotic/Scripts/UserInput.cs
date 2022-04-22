using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public GameObject m_XAxis;
    public GameObject m_YAxis;

    public float m_XRangeMin;
    public float m_XRangeMax;
    public float m_YRangeMin;
    public float m_YRangeMax;

    // Update is called once per frame
    void Update()
    {
         if(!PauseMenu.isPaused){
        if (Input.GetKey(KeyCode.LeftArrow) && m_XAxis.transform.position.x > m_XRangeMin)
             m_XAxis.transform.position -= new Vector3(0.01f, 0f, 0f);

        if (Input.GetKey(KeyCode.RightArrow) && m_XAxis.transform.position.x < m_XRangeMax)
             m_XAxis.transform.position += new Vector3(0.01f, 0f, 0f);

        if (Input.GetKey(KeyCode.UpArrow) && m_YAxis.transform.position.y < m_YRangeMax)
             m_YAxis.transform.position += new Vector3(0f, 0.01f, 0f);

        if (Input.GetKey(KeyCode.DownArrow) && m_YAxis.transform.position.y > m_YRangeMin)
             m_YAxis.transform.position -= new Vector3(0f, 0.01f, 0f);

      }
    }
}
