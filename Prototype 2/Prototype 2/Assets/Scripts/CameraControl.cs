using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
   public Camera perspectiveView;
   public KeyCode switchKey; 
   public Camera pOV;

    void Start()
    {
        
    }

  
    void Update()
    {
        if(Input.GetKeyDown(switchKey))
        {
            perspectiveView.enabled = !perspectiveView.enabled; 
            pOV.enabled = !pOV.enabled;
        }
    }
}
