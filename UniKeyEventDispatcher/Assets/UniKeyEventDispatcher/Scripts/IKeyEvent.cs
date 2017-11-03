using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

/// <summary>
/// キー押下時イベントのInterface
/// </summary>
public interface IKeyDownEvent : IEventSystemHandler {
    void OnKeyDown(List<KeyCode> downKeyList);
}
/// <summary>
/// キー押上時イベントのInterface
/// </summary>
public interface IKeyUpEvent : IEventSystemHandler {
    void OnKeyUp(List<KeyCode> upKeyList);
}