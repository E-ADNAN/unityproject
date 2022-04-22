using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAttach : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public FixedJoint m_FixedJoint;
    // Start is called before the first frame update
    void Start()
    {
        m_FixedJoint = this.gameObject.AddComponent<FixedJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            m_FixedJoint.connectedBody = null;
    }
    public void OnTriggerEnter(Collider other)

    {
        m_FixedJoint.connectedBody = other.attachedRigidbody;

    }

}