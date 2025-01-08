using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicks : MonoBehaviour
{
    public TextMeshProUGUI CountText;
    int Count;
    void ClickCount()
    {
        //Adding to my count by one 
        Count++;
        //Changing the ui text to show my count
        CountText.text = $"Count {Count}";
    }
    private void OnEnable()
    {
        //Subscribe to the action
        Actions.SpaceEvent += ClickCount;
    }
    private void OnDisable()
    {
        //Unsubscribe to the action
        Actions.SpaceEvent -= ClickCount;
    }
}
