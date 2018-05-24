﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : ScriptableObject {
    [Range(0,10)] public float PowerLevel = 0f;

    private void OnEnable()
    {
        Debug.Log("PowerUp");
    }
}
