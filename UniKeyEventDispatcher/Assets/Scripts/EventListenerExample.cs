using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventListenerExample : MonoBehaviour, IKeyUpEvent, IKeyDownEvent {

    Text testLabel;

    void Start() {
        testLabel = GetComponent<Text>();
    }

    public void OnKeyDown(List<KeyCode> downKeyList) {
        string labelText = "Down key: ";
        foreach (KeyCode key in downKeyList) {
            labelText += key.ToString() + " ";
        }
        testLabel.text = labelText;
    }

    public void OnKeyUp(List<KeyCode> upKeyList) {
        string labelText = "Up key: ";
        foreach (KeyCode key in upKeyList) {
            labelText += key.ToString() + " ";
        }
        testLabel.text = labelText;
    }
}
