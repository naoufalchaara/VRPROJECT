using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestCollider : MonoBehaviour
{

    public LayerMask m_mask;
    public UnityEvent m_onTouch ;
    private void OnCollisionEnter(Collision collision)
    {
        if (IsInLayerMask(collision.gameObject.layer, m_mask)) {
            Debug.Log("Bou");
            m_onTouch.Invoke();
        }
    }

    public static bool IsInLayerMask(int layer, LayerMask layermask)
    {
        return layermask == (layermask | (1 << layer));
    }
}
