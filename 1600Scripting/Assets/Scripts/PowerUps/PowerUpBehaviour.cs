using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehaviour : MonoBehaviour {

    public PowerUpBase PowerUp;
   bool displayed = false;

    private void OnMouseDown()
    {
        Debug.Log(PowerUp.PowerLevel);
    }

   void Update()
   {
      if (!displayed && PowerUp.PowerLevel == 10)
      {
         print("IT'S OVER 9000!");
      }
   }

}
