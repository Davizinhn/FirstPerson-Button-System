using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Crouch
{
    public bool crouchEnabled = true;
    public bool canCrouch=true;
    public bool isCrouched=false;
    public float crouchSpeed=2.5f;
    public KeyCode crouchKey = KeyCode.LeftControl;
}
