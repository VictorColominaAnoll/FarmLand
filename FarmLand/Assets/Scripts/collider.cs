using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour {
    public GameObject currentObject = null;

    void Update () {
        if (Input.GetButtonDown ("Interact") && currentObject) {
            currentObject.SendMessage("DoInteraction");
        }
    }

    void OnTriggerEnter2D (Collider2D other) {
        if (other.CompareTag ("Tree")) {
            Debug.Log ("JJ");
            currentObject = other.gameObject;
        }
    }

    void OnTriggerExit2D (Collider2D other) {
        if (other.CompareTag ("Tree")) {
            if (other.gameObject == currentObject)
                currentObject = null;
        }
    }
}