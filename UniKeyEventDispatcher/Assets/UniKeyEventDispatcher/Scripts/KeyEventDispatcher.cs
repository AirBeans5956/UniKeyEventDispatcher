using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.EventSystems;

/// <summary>
/// 各種のキー入力イベントの発行役
/// </summary>
public class KeyEventDispatcher : MonoBehaviour {

    /// <summary>
    /// 処理負荷軽減のため、KeyCodeの全ての値を保持する配列
    /// </summary>
    static Array KeyCodeList;

    public GameObject[] listeners;

    // Use this for initialization
    void Start() {
        //全てのKeyCode列挙型の値を控える
        KeyCodeList = Enum.GetValues(typeof(KeyCode));
    }

    // Update is called once per frame
    void Update() {
        if (listeners.Length > 0) {
            var tmpUpList = new List<KeyCode>();
            foreach (KeyCode code in KeyCodeList) {//押上キーがあるかチェック
                if (Input.GetKeyUp(code)) {
                    tmpUpList.Add(code);
                }
            }
            if (tmpUpList.Count != 0) {//1つでも押上キーがあれば
                foreach (GameObject listener in listeners) {
                    ExecuteEvents.Execute<IKeyUpEvent>(listener,
                        null,
                        (handler, eventData) => handler.OnKeyUp(tmpUpList) //押上キー全てを込めてリスナを叩く
                    );
                }
            }
            var tmpDownList = new List<KeyCode>();
            foreach (KeyCode code in KeyCodeList) {//押下キーがあるかチェック
                if (Input.GetKeyDown(code)) {
                    tmpDownList.Add(code);
                }
            }
            if (tmpDownList.Count != 0) {//1つでも押下キーがあれば
                foreach (GameObject listener in listeners) {
                    ExecuteEvents.Execute<IKeyDownEvent>(listener,
                        null,
                        (handler, eventData) => handler.OnKeyDown(tmpDownList) //押下キー全てを込めてリスナを叩く
                    );
                }
            }
        }
    }
}