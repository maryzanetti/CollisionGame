using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
  
  int hits = 0;  
  public void OnCollisionEnter(Collision other)
  {
      Debug.Log("Scorer Object");
      if(other.gameObject.tag != "Hit")
      {
        Debug.Log(other.gameObject.tag);
        hits++;
        Debug.Log("You've bumped into a thing this many times: " + hits );
      }
  }
}
