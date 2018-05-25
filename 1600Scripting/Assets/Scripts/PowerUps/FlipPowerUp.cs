using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class FlipPowerUp : PowerUpBase {

	private void OnMouseDown()
   {
      PowerLevel++;
   }
}
