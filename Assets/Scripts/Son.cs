using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Son : MonoBehaviour {


    public Transform _endPanel;
    public Camera _cam;

	void Update()
    {
        if (_cam.GetComponent<Blur>().enabled == true)
        {
            _cam.GetComponent<Blur>().iterations = (int)Mathf.Lerp(0f, 10f, 1f);
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        _cam.GetComponent<Blur>().enabled = true;
        
        StartCoroutine(SonEfect());

    }

    IEnumerator SonEfect()
    {
        yield return new WaitForSeconds(5);
        _endPanel.gameObject.SetActive(true);

        StopCoroutine(SonEfect());
    }
}
