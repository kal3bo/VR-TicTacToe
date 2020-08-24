using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class RealtimeThrowable : MonoBehaviour
{
    private RealtimeTransform realtimeTransform;
    private RealtimeView realtimeView;
    public int ownership = -1;

    private void Start()
    {
        realtimeTransform = gameObject.GetComponent<RealtimeTransform>();
        realtimeView = gameObject.GetComponent<RealtimeView>();
    }

    public void GrabbedObject()
    {
        realtimeTransform.RequestOwnership();
        realtimeView.RequestOwnership();
        ownership = realtimeTransform.ownerID;
    }

}
