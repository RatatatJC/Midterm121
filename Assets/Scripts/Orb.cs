using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
  [SerializeField] private float orb;

  private void OnTriggerEnter(Collider collision)
  {
    if (collision.tag == "Player")
    {
      Debug.Log("[ORB AQUIRED]");
      collision.GetComponent<PlayerHealth>().AddOrb(orb);
      Destroy(gameObject);
    }
  }
}