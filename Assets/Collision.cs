using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Oh crap! I think I hit something!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("What was that bump?");
    }
}
