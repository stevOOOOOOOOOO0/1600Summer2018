using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehaviour : MonoBehaviour {

    public PowerUpBase PowerUp;
    float rotateAngle = 0;

    private void OnMouseDown()
    {
        Debug.Log(PowerUp.PowerLevel);
    }

   void Update()
   {
      if (PowerUp.PowerLevel == 10)
      {
         if (transform.position.y > .5)
         {
            transform.Rotate(0, rotateAngle, 0);
            rotateAngle = rotateAngle + 0.5f;
         }
         else
            rotateAngle = 0;
      }
   }

}
