using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
   //destroy cacti after being jumped over using the destroyer
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

}
