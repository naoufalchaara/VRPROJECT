using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_FireScaleWithAnimation : MonoBehaviour
{
    public Ex_FireScale m_fireRef;
    public AnimationCurve m_intensity;

    public float m_timeOfLoop = 3;
    public float m_currentTime;

 
    void Update()
    {
        m_currentTime += Time.deltaTime;
        if (m_currentTime > m_timeOfLoop)
            m_currentTime = 0;
        float pct = m_currentTime / m_timeOfLoop;
        m_fireRef.SetWith(m_intensity.Evaluate(pct));


        
    }
}
