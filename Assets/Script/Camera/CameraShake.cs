using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private float shakeTimer;

    public static CameraShake instance { get; private set; }

    void Awake()
    {
        instance = this;
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    public void ShakeCamera(float duration, float intesity)
    {
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intesity;

        shakeTimer = duration;
    }

    void Update()
    {
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;

            if (shakeTimer <= 0f)
            {
                // Time Over
                CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0f;
            }
        }
    }
    /* public IEnumerator Shake(float duration, float magnitude)
     {
         Vector3 originalPos = transform.localPosition;

         float elapsed = 0.0f;

         while (elapsed < duration)
         {
             float x = Random.Range(-0.5f, 0.5f) * magnitude;
             float y = Random.Range(-0.5f, 0.5f) * magnitude;

             transform.localPosition = new Vector3(x, y, originalPos.z);
             elapsed += Time.deltaTime;


             yield return null;
         }
         transform.localPosition = originalPos;
         {

         }

     }*/
}
