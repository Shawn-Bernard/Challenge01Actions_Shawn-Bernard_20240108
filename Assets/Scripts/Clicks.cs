using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicks : MonoBehaviour
{
    public TextMeshProUGUI CountText;
    int Count;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse was clicked");
            Actions.ClickEvent?.Invoke();
        }
    }
    void ClickCount()
    {
        //Adding to my count by one 
        Count++;
        //Changing the ui text to show my count
        CountText.text = $"Clicks {Count}";
    }
    private void OnEnable()
    {
        //Subscribe to the action
        Actions.ClickEvent += ClickCount;
    }
    private void OnDisable()
    {
        //Unsubscribe to the action
        Actions.ClickEvent -= ClickCount;
    }
}
