using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    public Light _light;

    // Update is called once per frame
    void Update()
    {
        //Checking if any key was pressed
        if (Input.anyKeyDown)
        {
            Debug.Log("A key was pressed");
            Actions.LightEvent?.Invoke();
        }
    }
    void ColorChange() 
    {
        //Checking what key was pressed then changing the color
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Changing the light color to the color red
            _light.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            //Changing the light color to the color white
            _light.color = Color.white;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            //Changing the light color to the color blue
            _light.color = Color.blue;
        }
    }
    private void OnEnable()
    {
        //Subscribe to the action
        Actions.LightEvent += ColorChange;
    }
    private void OnDisable()
    {
        //Unsubscribe to the action
        Actions.LightEvent -= ColorChange;
    }
}
