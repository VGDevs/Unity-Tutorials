using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeteable : MonoBehaviour
{
    [SerializeField] private Transform m_body;

    public Transform Body
    {
        get => m_body;
        set => m_body = value;
    }

    public void Affect()
    {
    }
}
