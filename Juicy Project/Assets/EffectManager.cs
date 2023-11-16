using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] _effect;
    
    private ParticleSystemStopBehavior _systemStopBehavior;

    private void Start()
    {
        _systemStopBehavior = ParticleSystemStopBehavior.StopEmitting;
        // _effectOne.Stop(true, _systemStopBehavior);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EffectOne();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EffectTwo();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EffectThree();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            EffectFour();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            EffectFive();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            EffectSix();
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            EffectSeven();
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            EffectHeight();
        }
    }

    void EffectOne()
    {
        if (!_effect[0].isEmitting)
        {
            _effect[0].Play();
            Debug.Log("je t'active");
        }
        else
        {
            _effect[0].Stop(true, _systemStopBehavior);
            Debug.Log("je te desactive");
        }
    }
    void EffectTwo()
    {
        if (!_effect[1].isEmitting)
        {
            _effect[1].Play();
            Debug.Log("je t'active");
        }
        else
        {
            _effect[1].Stop(true, _systemStopBehavior);
            Debug.Log("je te desactive");
        }
    }
    void EffectThree()
    {
        if (!_effect[2].isEmitting)
        {
            _effect[2].Play();
            Debug.Log("je t'active");
        }
        else
        {
            _effect[2].Stop(true, _systemStopBehavior);
            Debug.Log("je te desactive");
        }
    }
    void EffectFour()
    {
        if (!_effect[3].isEmitting)
        {
            _effect[3].Play();
            Debug.Log("je t'active");
        }
        else
        {
            _effect[3].Stop(true, _systemStopBehavior);
            Debug.Log("je te desactive");
        }
    }
    void EffectFive()
    {
        if (!_effect[4].isEmitting)
        {
            _effect[4].Play();
            Debug.Log("je t'active");
        }
        else
        {
            _effect[4].Stop(true, _systemStopBehavior);
            Debug.Log("je te desactive");
        }
    }
    void EffectSix()
    {
        if (!_effect[5].isEmitting)
        {
            _effect[5].Play();
            Debug.Log("je t'active");
        }
        else
        {
            _effect[5].Stop(true, _systemStopBehavior);
            Debug.Log("je te desactive");
        }
    }
    void EffectSeven()
    {
        if (!_effect[6].isEmitting)
        {
            _effect[6].Play();
            Debug.Log("je t'active");
        }
        else
        {
            _effect[6].Stop(true, _systemStopBehavior);
            Debug.Log("je te desactive");
        }
    }
    void EffectHeight()
    {
        if (!_effect[7].isEmitting)
        {
            _effect[7].Play();
            Debug.Log("je t'active");
        }
        else
        {
            _effect[7].Stop(true, _systemStopBehavior);
            Debug.Log("je te desactive");
        }
    }
    
    
}
