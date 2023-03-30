using System;
using UnityEngine;

public class OPENDOOR : MonoBehaviour
{
    Animator _animator;
    private static readonly int IsOnCollision = Animator.StringToHash("IsOnCollision");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _animator.SetBool(IsOnCollision,true);
        _animator.Play("DoorOpenClose");
    }
}
