using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    private float _steerSpeed = 200f;

    [SerializeField]
    private float _moveSpeed = 10f;

    void Start()
    {
    }

    void Update()
    {
        var steerAmount = Input.GetAxis("Horizontal") * _steerSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);

        var moveAmount = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
    }
}
