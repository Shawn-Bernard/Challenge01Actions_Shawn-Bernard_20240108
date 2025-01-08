using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            //Debug.Log("A key was pressed");
            Actions.SpaceEvent?.Invoke();
        }
    }
}
