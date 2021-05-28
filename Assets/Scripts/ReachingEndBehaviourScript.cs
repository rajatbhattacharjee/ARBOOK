using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachingEndBehaviourScript : MonoBehaviour {

    // Use this for initialization
    Vector3 orginalPosition;
    void Start () {
        orginalPosition = transform.localPosition;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "END")
        {
            transform.localPosition = orginalPosition;
        }
        else if (other.gameObject.tag == "AWALL")
        {
            transform.localPosition = orginalPosition;
        }
        else if (other.gameObject.tag == "CWALL")
        {
            transform.localPosition = orginalPosition;
        }
    }
}
