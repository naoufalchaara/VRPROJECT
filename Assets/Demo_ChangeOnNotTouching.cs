using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Demo_ChangeOnNotTouching : MonoBehaviour
{
    public OverlapCastSelector m_selector;

    public Material m_materialColor;


    
    //public bool m_useTimerToLoadScene;
    //public float m_countDown=3;
    //public float m_countDownTimer;


    void Update()
    {
        bool hasCollision = m_selector.HasCollision();
        m_materialColor.color = hasCollision ? Color.green : Color.red;
        //if (hasCollision)
        //{
        //    m_countDownTimer = m_countDown;
        //}
        //else
        //{
        //    m_countDownTimer -= Time.deltaTime ;
        //    if (m_countDownTimer <= 0)
        //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //}
    }
}
