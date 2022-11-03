using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents instance;

    private void Awake()
    {
        if (!instance)
            instance = this;
    }

    public event Action OnDoorwayTriggerEnter;
    public void DoorwayTriggerEnter()
    {
        if(OnDoorwayTriggerEnter != null)
        {
            OnDoorwayTriggerEnter();
        }
    }


    public event Action OnDoorwayTriggerExit;
    public void DoorwayTriggerExit()
    {
        if (OnDoorwayTriggerExit != null)
        {
            OnDoorwayTriggerExit();
        }
    }
}
