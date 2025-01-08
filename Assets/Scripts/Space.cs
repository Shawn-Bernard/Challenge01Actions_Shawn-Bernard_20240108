using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Space : MonoBehaviour
{
    public GameObject Cube;

    void Scale()
    {
        //Adding to the scale of my cube by one each
        Cube.transform.localScale += new Vector3(1, 1, 1);
        

        //If my cube size is my "max size"
        if (Cube.transform.localScale == new Vector3(5, 5, 5))
        {
            //making my cube back to "normal size"
            Cube.transform.localScale = new Vector3(1, 1, 1);
        }

    }
    private void OnEnable()
    {
        //Subscribe to the action
        Actions.SpaceEvent += Scale;
    }
    private void OnDisable()
    {
        //Unsubscribe to the action
        Actions.SpaceEvent -= Scale;
    }
}
