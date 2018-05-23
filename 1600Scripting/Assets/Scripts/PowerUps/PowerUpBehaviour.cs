using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehaviour : MonoBehaviour {

    public PowerUpBase PowerUp;

    private void OnMouseDown()
    {
        Debug.Log(PowerUp.PowerLevel);
    }
}
