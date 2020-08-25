using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxHandler : MonoBehaviour
{
    [SerializeField] private GameObject OSlots;
    [SerializeField] private GameObject XSlots;

    /// <summary>
    /// Hidding available slots.
    /// </summary>
    public void HideObjects()
    {
        OSlots.SetActive(false);
        XSlots.SetActive(false);
    }

    /// <summary>
    /// When a player is holding a piece, the proper available slots will appear:
    /// </summary>
    /// <param name="isOSlots"></param>
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

    /// <summary>
    /// To restart we make all slots available but hidden.
    /// </summary>
    public List<GameObject> Slots = new List<GameObject>();
    public void Restart()
    {
        foreach(GameObject slot in Slots)
        {
            slot.SetActive(true);    
        }

        HideObjects();
    }
}
