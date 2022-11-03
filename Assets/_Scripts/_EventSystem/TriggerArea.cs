using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameEvents.instance.DoorwayTriggerEnter();
    }

    private void OnTriggerExit(Collider other)
    {
        GameEvents.instance.DoorwayTriggerExit();
    }
}
