using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("Key was pressed");
            ColorChange();
        }
    }
    void ColorChange() 
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q was pressed");
            light.color = Color.red;
            light.intensity = 100;
        }
    }
}
