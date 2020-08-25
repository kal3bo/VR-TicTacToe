using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Slot : MonoBehaviour
{
    [SerializeField] private BoxHandler boxHandler;
    [SerializeField] private StartGame startGame;
    private RealtimeTransform realtimeTransform;
    private bool isScriptAvailable = true;

    private void Awake()
    {
        realtimeTransform = gameObject.GetComponent<RealtimeTransform>();
    }

    /// <summary>
    /// Once a piece reaches a slot on board, the piece will attach to the slot position.
    /// The pice will stop being grabbable and this script will stop working.
    /// </summary>
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
            startGame.ToggleTurn();
        }
    }
    /// <summary>
    /// Restarting the game will restar the pieces position and make the script available again.
    /// </summary>
    public void Restart()
    {
        realtimeTransform.enabled = false;
        gameObject.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
        StartCoroutine(Wait(1));
        gameObject.GetComponent<Throwable>().forceDetach = false;
        isScriptAvailable = true;
        realtimeTransform.enabled = true;
    }

    IEnumerator Wait(int seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
