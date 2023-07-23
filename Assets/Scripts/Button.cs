using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    [Header("Event")]
    public UnityEngine.UI.Button.ButtonClickedEvent eventToExecute = new UnityEngine.UI.Button.ButtonClickedEvent();

    bool canPress;
    bool isPressing;
    bool isHitting;
    public enum Type
    {
        CanBePressedMultipleTimes,
        CanBePressedOneTime,
    }
    [Header("Settings")]
    public Type type;
    public KeyCode keyToPress=KeyCode.E;
    public float distance = 2f;
    public float timeOut = 2f;
    public GameObject clue;
    public bool isLocked;

    public void Start()
    {
        clue.GetComponent<TMP_Text>().text=keyToPress.ToString();
    }

    public void Update()
    {
        canPress=!isLocked&&!isPressing&&isHitting;
        clue.SetActive(canPress);
        if(canPress&&Input.GetKeyDown(keyToPress))
        {
            Pressing();
        }
        RaycastHit hit;
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Physics.Raycast(ray, out hit, distance)) {
            Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * distance, Color.green);
            isHitting=hit.collider.gameObject == this.gameObject;
        }else{isHitting=false;}
    }

    public void Pressing()
    {
        isPressing=true;
        this.gameObject.GetComponent<AudioSource>().Play();
        this.gameObject.GetComponent<Animator>().SetTrigger("Press");
        eventToExecute.Invoke();
        StartCoroutine(Pressing1());
    }

    public IEnumerator Pressing1()
    {
        yield return new WaitForSeconds(timeOut);
        if(type==Type.CanBePressedMultipleTimes)
        {
        isPressing=false;
        }else{isPressing=false; isLocked=true;}
        StopAllCoroutines();
    }

}
