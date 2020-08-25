using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxHandler : MonoBehaviour
{
    [SerializeField] private GameObject OSlots;
    [SerializeField] private GameObject XSlots;

    public void HideObjects()
    {
        OSlots.SetActive(false);
        XSlots.SetActive(false);
    }

    public void ShowSlots(bool isOSlots)
    {
        if (isOSlots)
        {
            OSlots.SetActive(true);
        }
        else
        {
            XSlots.SetActive(true);
        }
    }
}
