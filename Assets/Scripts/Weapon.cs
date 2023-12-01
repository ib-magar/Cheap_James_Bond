using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public float fireRate = 1f;

    private bool isReloading = false;
    private float nextFireTime = 0f;

    public ParticleSystem bulletfire;
    public void Shoot(Vector3 dir)
    {
       // if (Time.time < nextFireTime) return;

        bulletfire.Play();
        // Instantiate a new bullet
        GameObject bulletObject = ObjectPool.Instance.GetObject();
        bulletObject.transform.position = bulletSpawnPoint.position;
        // Set the bullet's direction
        Bullet bullet = bulletObject.GetComponent<Bullet>();
        if (bullet != null)
        {
            bullet.direction = dir;
        }

        // Set the next fire time
        nextFireTime = Time.time + 1f / fireRate;
    }

    public IEnumerator Reload(float reloadTime)
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        isReloading = false;
    }
}
