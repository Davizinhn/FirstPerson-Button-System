using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Run
{
    public bool canRun=true;
    public bool isRunning=false;
    public float runSpeed=6f;
    public float runFOV=70f;
    public KeyCode runKey = KeyCode.LeftShift;
}
