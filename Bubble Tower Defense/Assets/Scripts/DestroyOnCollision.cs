﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{

    private int health = 3;

    void RoundLost(){
        Debug.Log("PIERDUT");
    }


    void dropHp(){
        if(health > 0){
            health -= 1;
            Debug.Log(health);
        }
        else {
            RoundLost();
        }
    }

    private void OnCollisionEnter2D(Collision2D col) {
        Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
