using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using realvirtual;

public class StartStopButton : MonoBehaviour
{

 [Header("Factory Machine")]
    public int factoryMachineID;
    public OPCUA_Interface oPCUAinterface;
    public string nodeID1; // stop
    public string nodeID0; // start

    public void pushStartStopButton ()
    {
        Debug.Log("buttonON");
        oPCUAinterface.WriteNodeValue(nodeID0, false);
        oPCUAinterface.WriteNodeValue(nodeID1, true);

    }
}
