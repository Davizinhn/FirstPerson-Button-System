using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public Animator Door;
    public void ExampleTrigger()
    {
        Debug.Log("The example was triggered!");
    }

    public void OpenDoor()
    {
        Door.SetBool("Opened", !Door.GetBool("Opened"));
    }
}
