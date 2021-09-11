using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HeroClass
{
    Warrior,
    Mage,
    Archer
}

public class Hero : MonoBehaviour
{
    [SerializeField]
    private HeroClass HeroClass;

    [SerializeField]
    private int Damage;

    [SerializeField]
    private int Attack;

    [SerializeField]
    private int ArrowDamage;

    public void Move()
    {
        transform.position += Vector3.forward;
    }
}
