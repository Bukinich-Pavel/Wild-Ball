using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        _animator.SetInteger("SelectAnim", Random.Range(0, 3));
    }
}
