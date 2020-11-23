using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
   private GameObject player;
   public float sensitivity = 1f;

    private void Awake()
   {
      player=this.gameObject;
        
   }

 
   private void Update() 
   {
      
      float rotateHorizontal = Input.GetAxis ("Mouse X");
      float rotateVertical = Input.GetAxis ("Mouse Y");
      transform.RotateAround (player.transform.position, -Vector3.up, rotateHorizontal * sensitivity); //use transform.Rotate(-transform.up * rotateHorizontal * sensitivity) instead if you dont want the camera to rotate around the player
      transform.RotateAround (Vector3.zero, transform.right, rotateVertical * sensitivity); // again, use transform.Rotate(transform.right * rotateVertical * sensitivity) if you don't want the camera to rotate around the player
   }
}
    
     
