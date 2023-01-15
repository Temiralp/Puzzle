using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
   public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = new Vector2(10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        PlayerMovement.score++;
        Debug.Log(PlayerMovement.score);
        Destroy(this.gameObject);
    }
}
