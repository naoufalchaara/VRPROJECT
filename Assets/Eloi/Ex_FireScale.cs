using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_FireScale : MonoBehaviour
{

    [Range(0,1f)]
    public float m_pourcentFireIntensity;
    [Header("Light")]
    public Light m_fireLight;
    public float m_maxLightRange=10;
    public float m_maxLightIntensity=2;

    [Header("Scale")]
    public GameObject m_fireRoot;
    public float m_maxScale=3;


    void Update()
    {

        SetWith(m_pourcentFireIntensity);
    }

    private void OnValidate()
    {
        if(!Application.isPlaying)
        SetWith(m_pourcentFireIntensity);
    }

    public  void SetWith(float pourcent)
    {
        m_pourcentFireIntensity = pourcent;
        m_fireLight.range = m_pourcentFireIntensity * m_maxLightRange;
        m_fireLight.intensity = m_pourcentFireIntensity * m_maxLightIntensity;
        m_fireLight.intensity = m_pourcentFireIntensity * m_maxLightIntensity;
        m_fireRoot.transform.localScale = Vector3.one * m_maxScale * m_pourcentFireIntensity;
    }
}
