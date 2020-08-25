using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncHidden : MonoBehaviour
{
    [SerializeField] GameObject objectToSync;

    // Update is called once per frame
    private void Update()
    {
        if (!objectToSync.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }
}
