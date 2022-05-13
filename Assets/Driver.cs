using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    private float _steerSpeed = 1f;

    [SerializeField]
    private float _moveSpeed = 0.01f;

    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(0, 0, _steerSpeed);
        transform.Translate(0, _moveSpeed, 0);
    }
}
