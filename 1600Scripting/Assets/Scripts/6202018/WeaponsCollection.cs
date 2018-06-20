using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WeaponsCollection : ScriptableObject
{

    public List<WeaponObject> Weapons;

    public void CollectWeapon(WeaponObject weapon)
    {
        Weapons.Add(weapon);
        Debug.Log(weapon);
    }

}
