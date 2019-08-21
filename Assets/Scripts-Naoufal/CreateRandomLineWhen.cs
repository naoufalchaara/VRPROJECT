using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomLineWhen : MonoBehaviour
{

    public RandomLine m_builder;

    public bool m_createAtStart;
    public KeyCode m_keyToSwitch = KeyCode.Keypad1;
    // Start is called before the first frame update
    void Start()
    {
        if (m_createAtStart)
            m_builder.LoadNextLine();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(m_keyToSwitch))
            m_builder.LoadNextLine();

    }
}
