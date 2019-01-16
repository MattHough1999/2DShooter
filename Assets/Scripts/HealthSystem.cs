using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }
public class HealthSystem : MonoBehaviour
{
    public int health = 10;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;
    public void TakeDamage(int damage)
    {
        health -= damage;
        onDamaged.Invoke(health);
        if (health < 1)
        {
            onDie.Invoke();
        }
    }
    public int Stealth = 10;
    public UnityEvent onDectected;
    public OnDamagedEvent onDetect;
    public void TakeStealth(int damage)
    {
        Stealth -= damage;
        onDamaged.Invoke(health);
        if (health < 1)
        {
            onDie.Invoke();
        }
    }
}
