using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlaneScript : MonoBehaviour {

	// Use this for initialization
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Boat_1800early_BrigSloop_LOD_0")
        {
            Debug.Log("BATMAN!");
            //print("No longer in contact with " + gameObject.transform.name);
            //other.gameObject.transform.position = new Vector3(0, 0, 0);
            Destroy(other.gameObject);
        }
    }
}
