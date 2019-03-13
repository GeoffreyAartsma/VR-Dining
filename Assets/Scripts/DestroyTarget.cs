using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
   void OnTriggerEnter(Collider collider)
   {
       if (collider.gameObject.tag == "Food")
       {
           print ("Joop got desrtoyed!!");
           Destroy (gameObject);
       }
   }
}
