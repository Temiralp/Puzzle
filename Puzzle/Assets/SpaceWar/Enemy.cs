using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D enemyRb;
    private void Start()
    {
        enemyRb.velocity = new Vector2(-10, 0);

    }
    // Update is called once per frame
    void Update()
    {

        
    }
}
