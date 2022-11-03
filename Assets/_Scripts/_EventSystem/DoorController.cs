using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();

        GameEvents.instance.OnDoorwayTriggerEnter += OnDoorwayOpen;
        GameEvents.instance.OnDoorwayTriggerExit += OnDoorwayClose;
    }

    public void OnDoorwayOpen()
    {
        _animator.Play("OpenDoorAnimation");
    }

    public void OnDoorwayClose()
    {
        _animator.Play("CloseDoorAnimation");
    }
}
