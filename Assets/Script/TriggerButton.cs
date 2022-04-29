using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;
    private ParticleSystem[] _particleSystems;

    private void Start()
    {
        _particleSystems = transform.GetComponentsInChildren<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _cube.SetActive(false);
        _particleSystems[0].Stop();
        _particleSystems[1].Play();
    }
}
