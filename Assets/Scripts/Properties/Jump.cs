using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Jump
{
    public bool canJump=true;
    public float jumpForce=2f;
    public float gravityScale = 2f;
    public KeyCode jumpKey = KeyCode.Space;
    public bool isGrounded=false;
    public LayerMask groundLayer;
    public Transform groundChecker;
}
