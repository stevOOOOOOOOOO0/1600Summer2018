using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WeaponObject : ScriptableObject
{

    public float Damagelevel = 10.0f;

    public float DoDamage()
    {
        return Damagelevel;
    }

}
