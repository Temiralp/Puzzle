using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        Instantiate(bullet,transform.position,Quaternion.identity);
    }
}
