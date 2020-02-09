using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollission : MonoBehaviour {

    public GameObject currentObject = null;

    void OnTriggerEnter2D (Collider2D other) {

        if (other.CompareTag ("Tree")) {
            Debug.Log ("JJ");
            currentObject = other.gameObject;
        }
        else
            Debug.Log ("74");
    }
}