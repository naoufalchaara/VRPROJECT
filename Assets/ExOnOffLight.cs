using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExOnOffLight : MonoBehaviour
{

    public Ex_FireScale mFire;
    //public float mWantedPourcent;
    // Start is called before the first frame update

    public bool mState;
    public float mWantedPowerPourcent;
    public float speed = 2;

    void OnEnable()
    {
        EventManager.OnClick += LIghtOn;

    }

    private void LIghtOn(bool isOn)
    {
        //mState = !mState;
        // mFire.SetWith(mState ? 1f:0f);
        mWantedPowerPourcent = isOn ? 1f : 0f;

    }

    public void Update()
    {
        mFire.SetWith( Mathf.Lerp(mFire.m_pourcentFireIntensity, mWantedPowerPourcent, Time.deltaTime * speed));
    }

    private void OnDisable()
    {
        EventManager.OnClick -= LIghtOn;
    }

    private void LightOff()
    {
        mFire.SetWith(0);
    }
}
