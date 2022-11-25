using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitcher : MonoBehaviour
{
    public Light myLight; /*light variable visible in unity inspector*/

    void MyFunction()
    {
        myLight.enabled = !myLight.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            MyFunction();
        }
    }
}
  