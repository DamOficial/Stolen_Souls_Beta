using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzController : MonoBehaviour
{
    public Light luzLinterna;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Luz"))
        {
            if(luzLinterna.enabled == true)
            {
                luzLinterna.enabled = false;
            }
            else if (luzLinterna.enabled == false)
            {
                luzLinterna.enabled = true;
            }
        }
    }
}
