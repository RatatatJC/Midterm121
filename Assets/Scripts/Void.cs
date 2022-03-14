using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : MonoBehaviour
{
  [SerializeField] private float damage;

  private void OnTriggerEnter(Collider collision)
  {
    if (collision.tag == "Player")
    {
      Debug.Log("AHK!");
      collision.GetComponent<PlayerHealth>().TakeDamage(damage);
      Destroy(gameObject);
    }
  }
}
