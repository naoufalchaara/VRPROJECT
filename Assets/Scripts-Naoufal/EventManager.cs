using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void DesactivateLight(bool lightStateOn);
    public static event DesactivateLight OnClick;
    public AudioSource Laugh;
    public AudioSource Whisper;
    public AudioSource Electric;



  

    public  void SendSwitchLightEvent()
    {
        if (OnClick != null)
        {
            StartCoroutine(Switch());
            // OnClick();
            
        }
    }

    public IEnumerator Switch()
    {
        OnClick(true);
        yield return new WaitForSeconds(1);
        Electric.Play();
        OnClick(false);
        yield return new WaitForSeconds(0.2f);
        OnClick(true);
        yield return new WaitForSeconds(1.6f);
        Electric.Play();

        bool state = false;
        for (int i = 0; i < 40; i++)
        {
            OnClick(state);
            state = !state;
            yield return new WaitForSeconds(0.1f);
            

        }
        OnClick(false);
        yield return new WaitForSeconds(2f);
        Laugh.Play();
        yield return new WaitForSeconds(5f);
        Whisper.Play();
    }

}
