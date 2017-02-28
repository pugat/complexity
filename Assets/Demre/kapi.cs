using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapi : MonoBehaviour {

    public Transform _kapi;
    bool _isOpen = false;
    bool trg = false;

    void Update()
    {
        //_kapi.Rotate(0f, Mathf.Lerp(90f, 90f, 5f), 0f);
        if (_isOpen && !trg)
        {
            //kapı ac
            if (_kapi.localRotation.y == 0)
            {
                _kapi.Rotate(0f, 90f, 0f);
                trg = true;
                //_isOpen = false;
            }//kapı kapa
            else //if (_kapi.localRotation.y == 90)
            {
                _kapi.Rotate(0f, -90f, 0f);
                trg = true;
                //_isOpen = false;
            }
            
        }
        
        
        
    }

    void OnTriggerEnter(Collider _col)//tetikleme varsa
    {
        if (_col.tag == "Player")
        {
            trg = false;
            _isOpen = true;
        }
    }
    void OnTriggerExit(Collider _col)//tetikten cıkışsa
    {
        if (_col.tag == "Player")
        {
            trg = false;
            _isOpen = true;
        }
    }

}
