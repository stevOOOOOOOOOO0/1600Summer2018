using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCubeMovement : MonoBehaviour {
   
   private Animator anims;
   private CharacterController controller;
   private Vector3 movement;
   
	// Use this for initialization
	void Start () {
      anims = GetComponent<Animator>();
      controller = GetComponent<CharacterController>();
   }

   private void OnMouseDown()
   {
      anims.SetTrigger("Reving");
   }

   private void OnMouseUpAsButton()
   {
      Move(20);
   }

   private void Move(float speed)
   {
      movement.x = speed;
      Debug.Log("on it");
      controller.Move(movement);
   }
}
