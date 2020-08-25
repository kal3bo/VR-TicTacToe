using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject turnBall;
    private int randomStarter = 0;
    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<Animator>().SetTrigger("Play");
        randomStarter = Random.Range(0, 2);
        turnBall.SetActive(true);

        if(randomStarter == 0)
        {
            turnBall.transform.position = new Vector3(15.365f, 1.341f, 2.355f);
        }
        else
        {
            turnBall.transform.position = new Vector3(15.365f, 1.341f, 1.002f);
        }
    }
}
