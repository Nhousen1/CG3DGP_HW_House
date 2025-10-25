using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject shootPoint;

    public ParticleSystem muzzleEffect;

    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, shootPoint.transform.rotation);

            muzzleEffect.Play();
        }   
    }
}
