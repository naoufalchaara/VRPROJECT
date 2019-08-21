using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{

    private RaycastHit Hit;
    private Ray ray;
    public float RayDistance = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ray = new Ray(transform.position + new Vector3(0f, GetComponent .center.y, 0f), transform.forward);
        //Debug.DrawRay(ray.origin, ray.direction * RayDistance, Color.red);

    }
}
