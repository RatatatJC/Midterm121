using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
  [SerializeField] private float healthValue;

  private void OnTriggerEnter(Collider collision)
  {
    if (collision.tag == "Player")
    {
      Debug.Log("NICE! +10");
      collision.GetComponent<PlayerHealth>().AddHealth(healthValue);
      Destroy(gameObject);
    }
  }
}
