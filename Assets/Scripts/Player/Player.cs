using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _speed = 1000;
    private int _rotationSpeed = 20;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(movement), _rotationSpeed);
        _rigidbody.AddForce(movement * _speed);
    }
}
