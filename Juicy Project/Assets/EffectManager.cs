using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] _effect;
    
    private ParticleSystemStopBehavior _systemStopBehavior;

    private static EffectManager instance = null;
    public static EffectManager Instance => instance;

    public bool effect5;
    public bool effect6;
    

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

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
            if (effect5 == false)
            {
                effect5 = true;
            }
            else
            {
                effect5 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (effect6 == false)
            {
                effect6 = true;
            }
            else
            {
                effect6 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            EffectFour();
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            EffectFive();
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
    
    
    
}
