using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject Stone;
    public GameObject Player;
    void Start()
    {

        
    }


    void OnTriggerEnter2D(Collider2D myTrigger)
    {
        if (myTrigger.gameObject == Player)
        {
            Stone.SetActive(true);
            print("f");

        }
    }
}
