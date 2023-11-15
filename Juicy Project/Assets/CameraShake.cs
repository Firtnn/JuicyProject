using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    
    [SerializeField] private float shakeDuration;
    [SerializeField] private float shakeStrenght;
    private bool isShaking = false;
    [SerializeField] private Vector3 camPosition;
    [SerializeField] private Quaternion camRotation;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ResetCamPos());
        }
    }

    private void ShakeCam()
    {
        Camera.main.DOShakeRotation(shakeDuration, shakeStrenght, fadeOut: true);
        Camera.main.DOShakePosition(shakeDuration, shakeStrenght, fadeOut: true);
    }

    private IEnumerator ResetCamPos()
    {
        if (isShaking == false)
        {
            isShaking = true;
            ShakeCam();
            yield return new WaitForSeconds(shakeDuration);
            Camera.main.transform.position = camPosition;
            Camera.main.transform.rotation = camRotation;
            isShaking = false;

        }
    }
}
