using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Vector3 direction;

    [SerializeField] private float speed;
    public System.Action destroyed;
    [SerializeField] private ParticleSystem _effect;
    [SerializeField] private ParticleSystem _effect2;

    private ParticleSystemStopBehavior _systemStopBehavior;

    private void Start()
    {
        if (EffectManager.Instance.effect5)
        {
            _effect.Stop(true, _systemStopBehavior);
            _effect2.Stop(true, _systemStopBehavior);
        }
        else
        {
            _effect.Play();
            _effect2.Play();
        }
    }

    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(this.destroyed != null)
        {
            this.destroyed.Invoke();
        }
        Destroy(this.gameObject);
    }
}
