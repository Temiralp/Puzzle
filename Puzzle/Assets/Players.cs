using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public GameObject test;
    public GameObject rank_1;
    void Start()
    {
        rank_1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos);
        transform.position = Vector2.MoveTowards(transform.position, mousePos,0.1f);
    }
}
