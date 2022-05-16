using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    private float _steerSpeed = 200f;

    [SerializeField]
    private float _moveSpeed = 10f;

    [SerializeField]
    private float _slowSpeed = 5f;

    [SerializeField]
    private float _boostSpeed = 15f;

    void Update()
    {
        var steerAmount = Input.GetAxis("Horizontal") * _steerSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);

        var moveAmount = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _moveSpeed = _slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            _moveSpeed = _boostSpeed;
        }
    }
}
