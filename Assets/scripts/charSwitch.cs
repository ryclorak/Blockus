using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charSwitch : MonoBehaviour {
    public GameObject blockus, spherus;
    int whichChar = 0;
    void Start() {
        blockus = GameObject.Find("Blockus");
        spherus = GameObject.Find("Spherus");
        
        blockus.gameObject.SetActive(true);
        spherus.gameObject.SetActive(false);
    }

    public void SwitchChar() {
        switch(whichChar) {
            case 0:
                whichChar = 1;
                blockus.gameObject.SetActive(false);
                spherus.gameObject.SetActive(true);
                break;
            case 1:
                whichChar = 0;
                blockus.gameObject.SetActive(true);
                spherus.gameObject.SetActive(false);
                break;
        }
    }
    private void OnTriggerExit(Collider other) {
        SwitchChar();
    }
}
