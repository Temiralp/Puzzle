using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
   public static int score;
    public GameObject topTarget;
    public GameObject bottomTarget;
    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        transform.position = Vector3.MoveTowards(transform.position, topTarget.transform.position, 0.1f);
        if (Input.GetKey(KeyCode.S))
            transform.position = Vector3.MoveTowards(transform.position, bottomTarget.transform.position, 0.1f);
    }

}
