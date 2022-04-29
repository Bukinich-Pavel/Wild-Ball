using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ControllerPlayer : MonoBehaviour
{
    [SerializeField, Range(0, 10)] private float _speed = 2.0f;
    private Rigidbody _playerRigidbody;
    private Vector3 _movement;
    private ParticleSystem _particleSystem;


    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
        _particleSystem = transform.GetComponentInChildren<ParticleSystem>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        _movement = new Vector3(-horizontal, 0, -vertical).normalized;
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        _playerRigidbody.AddForce(_movement*_speed);
    }


    private void OnCollisionEnter(Collision collision)
    {
        var anim = collision.gameObject.GetComponent<Animator>();
        if (anim != null)
        {
            _particleSystem.Play();
        }
    }


#if UNITY_EDITOR
    [ContextMenu("Reset value")]
    public void ResetValue()
    {
        _speed = 2.0f;
    }
#endif
}
