using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTrigger : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;
    [SerializeField] private GameObject _cube;
    private ParticleSystem[] _particleSystems;
    public bool __winGame;

    private void Start()
    {
        _particleSystems = transform.GetComponentsInChildren<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _canvas.gameObject.SetActive(true);

        if (__winGame)
        {
            foreach (var item in _particleSystems)
            {
                item.Play();
            }
            _cube.SetActive(true);
            return;
        }

        Time.timeScale = 0;
    }

}
