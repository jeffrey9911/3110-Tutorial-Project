using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class DropdownHandler : MonoBehaviour
{
    TMP_Dropdown _dropdown;

    public List<GameObject> allPanels;

    private void Start()
    {
        _dropdown = GetComponent<TMP_Dropdown>();

        DeactivateAllPanels();
        DropdownItemSelected(_dropdown);

        _dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(_dropdown); });
    }

    public void DropdownItemSelected(TMP_Dropdown dropdown)
    {
        int index = _dropdown.value;

        switch(index)
        {
            case 0:
                DeactivateAllPanels();
                allPanels[0].SetActive(true);
                break;

            case 1:
                DeactivateAllPanels();
                allPanels[1].SetActive(true);
                break;

            case 2:
                DeactivateAllPanels();
                allPanels[2].SetActive(true);
                break;


            default:
                break;
        }
    }

    void DeactivateAllPanels()
    {
        foreach(var panel in allPanels)
        {
            panel.SetActive(false);
        }
    }
}
