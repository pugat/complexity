using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavanDusme : MonoBehaviour {

    public Transform _tavan;

    //void 

    void OnTriggerExit()
    {
        Debug.Log("sasa");
        transform.GetComponent<BoxCollider>().enabled = true;
        _tavan.GetComponent<BoxCollider>().enabled = true;
    }
}
