using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Slot : MonoBehaviour
{
    [SerializeField] private BoxHandler boxHandler;
    private bool isScriptAvailable = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Slot" && isScriptAvailable)
        {
            gameObject.GetComponent<Throwable>().forceDetach = true;
            gameObject.transform.position = other.gameObject.transform.position;
            gameObject.transform.rotation = other.gameObject.transform.rotation;
            other.gameObject.SetActive(false);
            boxHandler.HideObjects();
            isScriptAvailable = false;
        }
    }
}
