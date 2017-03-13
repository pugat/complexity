using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Not : MonoBehaviour {

    public GameObject _textTransform;
    public Transform _kapi;

    //public Text _text;
    bool not = false;

    void Update()
    {
        if (not == true && Input.GetKeyDown(KeyCode.E))
        {
            _textTransform.SetActive(true);

        }
    }

	void OnTriggerEnter(Collider coll){
		if(coll.tag == "Player")
		{
			Debug.Log("E ye bas");
			not = true;
			StartCoroutine(NotI());
		}
	}
	
	IEnumerator NotI(){
		yield return new WaitForSeconds(5);
		_textTransform.SetActive(false);
        _kapi.GetComponent<BoxCollider>().enabled = false;
		not = false;
        StopCoroutine(NotI());
	}
}
