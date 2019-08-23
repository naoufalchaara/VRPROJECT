using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public Light lignt;
    // Start is called before the first frame update
    void OnEnable()
    {
        EventManager.OnClick += Desactivate;
        
    }

    // Update is called once per frame
    void Desactivate(bool isOn)
    {
        lignt.enabled = isOn;
    }

    private void OnDisable()
    {
        EventManager.OnClick -= Desactivate;
    }

    private void Reset()
    {
        this.lignt = GetComponent<Light>();
    }
}
