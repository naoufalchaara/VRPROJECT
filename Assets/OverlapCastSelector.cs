
using System;
using System.Collections;
using System.Linq;
using UnityEngine;

public class OverlapCastSelector : MonoBehaviour
{

    public Transform m_where;
    public float m_radius = 5;
    public LayerMask m_lookFor;
    public Collider[] m_touchingCollider;
    public GameObject[] m_touchingGameObject;
    public float m_checkDelay = 0.25f;

    public bool m_useDebugDraw;

    internal bool HasCollision()
    {
        return m_touchingCollider.Length > 0;
    }

    public IEnumerator Start()
    {

        while (true)
        {
            yield return new WaitForEndOfFrame();
            yield return new WaitForSeconds(m_checkDelay);
            m_touchingCollider = Physics.OverlapSphere(m_where.position, m_radius, m_lookFor);
            m_touchingGameObject = m_touchingCollider.Select(k => k.gameObject).ToArray();
        }
    }

    public void Update()
    {
        if (m_useDebugDraw) {
            Debug.DrawLine(m_where.position - Vector3.up*m_radius, m_where.position + Vector3.up * m_radius, Color.green, Time.deltaTime);
            Debug.DrawLine(m_where.position - Vector3.right * m_radius, m_where.position + Vector3.right * m_radius, Color.green, Time.deltaTime);
            Debug.DrawLine(m_where.position - Vector3.forward * m_radius, m_where.position + Vector3.forward * m_radius, Color.green, Time.deltaTime);
        }
    }

    public bool HasCollisionWith(GameObject target, out Collider collision)
    {

        collision = null;
        Collider[] possibilities = m_touchingCollider.Where(k => k.gameObject == target).ToArray();

        if (possibilities.Length > 0)
        {
            collision = possibilities[0];
            return true;
        }
        return false;

    }


}