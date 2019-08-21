using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTouchingObject : MonoBehaviour
{
    public List<GameObject > objectTouch;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        objectTouch.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {

        objectTouch.Remove(other.gameObject);
    }

    private bool IsTouchingNothing()
    {

        return objectTouch.Count < 0;

    }

    public bool IsTouchingThis(GameObject obj)
    {

       return  objectTouch.Contains(obj);

    }

}
