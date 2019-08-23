using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void DesactivateLight(bool lightStateOn);
    public static event DesactivateLight OnClick;
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (OnClick != null)
            {
                StartCoroutine(Switch());
               // OnClick();
            }
        }
    }


    public IEnumerator Switch()
    {
        OnClick(true);
        yield return new WaitForSeconds(1);
        OnClick(false);
        yield return new WaitForSeconds(0.2f);
        OnClick(true);
        yield return new WaitForSeconds(1.6f);
        bool state = false;
        for (int i = 0; i < 40; i++)
        {
            OnClick(state);
            state = !state;
            yield return new WaitForSeconds(0.1f);

        }
        OnClick(false);

    }

}
