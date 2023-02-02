using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public GameObject kid;
   public GameObject ninja;
  public Vector3 offset;
  
  void LateUpdate () 
  {
    
      transform.position = (kid.activeSelf) ? new Vector3 (kid.transform.position.x + offset.x, kid.transform.position.y + offset.y, offset.z) : new Vector3(ninja.transform.position.x + offset.x, ninja.transform.position.y + offset.y, offset.z);

      //transform.position = new Vector3 (kid.position.x + offset.x, kid.position.y + offset.y, offset.z); // Camera follows the player with specified offset position

  }
}

    
