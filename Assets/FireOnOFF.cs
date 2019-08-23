using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOnOFF : MonoBehaviour
{
    public GameObject mfireRoot;


    [Range(0f,1f)]
    public float mPourcent;
    public float mMaxScale=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            mfireRoot.SetActive(!mfireRoot.activeSelf);
   
      


    }

    private void OnValidate()
    {
        mfireRoot.transform.localScale = Vector3.one * mPourcent * mMaxScale;
    

    }
}
