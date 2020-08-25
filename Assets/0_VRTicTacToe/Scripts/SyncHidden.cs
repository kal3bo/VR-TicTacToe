using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncHidden : MonoBehaviour
{
    [SerializeField] GameObject objectToSync;

    // Everytime a slot is occupied will hide both available meshes:
    private void Update()
    {
        if (!objectToSync.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }
}
