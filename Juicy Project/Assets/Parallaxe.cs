using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallaxe : MonoBehaviour
{
    [SerializeField] private Image _cityFar;
    [SerializeField] private Image _cityMedium;
    [SerializeField] private Image _cityClose;

    [SerializeField] private float _cityFarSpeed;
    [SerializeField] private float _cityMediumSpeed;
    [SerializeField] private float _cityCloseSpeed;
 
    public void SlideRight()
    {
        _cityFar.transform.position += Vector3.left * _cityFarSpeed * Time.deltaTime;
        _cityMedium.transform.position += Vector3.left * _cityMediumSpeed * Time.deltaTime;
        _cityClose.transform.position += Vector3.left * _cityCloseSpeed * Time.deltaTime;
    }
    
    public void SlideLeft()
    {
        _cityFar.transform.position += Vector3.right * _cityFarSpeed * Time.deltaTime;
        _cityMedium.transform.position += Vector3.right * _cityMediumSpeed * Time.deltaTime;
        _cityClose.transform.position += Vector3.right * _cityCloseSpeed * Time.deltaTime;
    }
}
