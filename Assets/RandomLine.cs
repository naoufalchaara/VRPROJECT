
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLine : MonoBehaviour
{
    public GameObject [] m_linesProposition;

    public Transform m_whereToCreate;



    [Header("Debug")]
    public GameObject m_created;



    public void LoadNextLine() {

        if (m_created)
            Destroy(m_created);

        m_created = Instantiate(GetRandomLine(), m_whereToCreate.position, m_whereToCreate.rotation);
    }

    private GameObject GetRandomLine()
    {
        return m_linesProposition[UnityEngine.Random.Range(0, m_linesProposition.Length)];
    }
}
