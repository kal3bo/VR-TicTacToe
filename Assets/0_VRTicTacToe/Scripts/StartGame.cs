using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject turnBall;
    private int randomStarter = 0;
    private int turn = 0;
    private bool isGameStarted = false;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<Animator>().SetTrigger("Play");
        randomStarter = Random.Range(0, 2);
        
        if (!isGameStarted)
        {
            turnBall.SetActive(true);
            switch (randomStarter)
            {
                case 0:
                    turnBall.transform.position = new Vector3(15.365f, 1.341f, 2.355f);
                    turn = 0;
                    break;
                case 1:
                    turnBall.transform.position = new Vector3(15.365f, 1.341f, 1.002f);
                    turn = 1;
                    break;
            }
            isGameStarted = true;
        }

        else
        {
            Restart();
        }
    }

    public void ToggleTurn()
    {
        switch (turn)
        {
            case 0:
                turnBall.transform.position = new Vector3(15.365f, 1.341f, 1.002f);
                break;
            case 1:
                turnBall.transform.position = new Vector3(15.365f, 1.341f, 2.355f);
                break;
        }
    }

    [SerializeField] private BoxHandler boxHandler;
    [SerializeField] private List<Slot> pieces;
    public void Restart()
    {
        boxHandler.Restart();

        foreach(Slot piece in pieces)
        {
            piece.Restart();
        }
    }
}
