using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("Currently no headset plugged");
        } 
        else if (XRSettings.isDeviceActive && 
            (XRSettings.loadedDeviceName == "MockHMD Display"
            || XRSettings.loadedDeviceName == "MockHMDDisplay"))
        {
            Debug.Log("Using MockHMD Display");
        }
        else
        {
            Debug.Log($"Currently we have connected headset {XRSettings.loadedDeviceName}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
