using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
  public float healthAmount = 100;
  public float orbAmount = 0;

  private void Update()
  {
    if(healthAmount <= 0)
    {
      Debug.Log("you lose");
      Application.LoadLevel(Application.loadedLevel);
    }
    if(orbAmount >= 5)
    {
      Debug.Log("you win");
      Application.LoadLevel(Application.loadedLevel);
    }
  }

  public void TakeDamage(float damage)
  {
    healthAmount -= damage;

  }

  public void AddHealth(float value)
  {
    healthAmount += value;
    healthAmount = Mathf.Clamp(healthAmount, 0, 100);

  }
  public void AddOrb(float orb)
  {
    orbAmount += orb;
    orbAmount = Mathf.Clamp(orbAmount, 0, 5);
  }
}
