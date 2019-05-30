using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody m_rb = null;
    Animator m_animator = null;
    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        m_animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 translate = Vector3.zero;
        translate.z = Input.GetAxis("Vertical");
        translate.x =  Input.GetAxis("Horizontal");

        if (translate.x > 0.0f || translate.z > 0.0f)
        {
            m_animator.SetBool("Walking", true);
        }
        else
        {
            m_animator.SetBool("Walking", false);
        }

        m_rb.velocity= translate;
    }
}
