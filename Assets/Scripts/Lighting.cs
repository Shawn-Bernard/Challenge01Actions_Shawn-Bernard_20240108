using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    public Light _light;
    bool Pressed = true;
    void ColorChange()
    {
        //If pressed is true then change the color and make pressed false
        if (Pressed == true)
        {
            _light.color = Color.red;
            Pressed = false;
        }
        //If pressed is false then change the color and make pressed false
        else if (Pressed == false)
        {
            _light.color = Color.white;
            Pressed = true;
        }
        
    }
    private void OnEnable()
    {
        //Subscribe to the action
        Actions.SpaceEvent += ColorChange;
    }
    private void OnDisable()
    {
        //Unsubscribe to the action
        Actions.SpaceEvent -= ColorChange;
    }
}
