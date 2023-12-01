using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{

    [SerializeField] Weapon defaultWeapon;
    private Weapon currentWeapon;
    private void Start()
    {
        currentWeapon = defaultWeapon;
    }
    public void Shoot(Vector3 dir)
    {
        //if (currentWeapon == null) return;
        currentWeapon.Shoot(dir);
    }

}
