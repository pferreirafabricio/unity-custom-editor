using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HeroClass
{
    Warrior,
    Mage,
    Archer
}

[ExecuteAlways]
[RequireComponent(typeof(Rigidbody))]
public class Hero : MonoBehaviour
{
    [Tooltip("Hero class to choose")]
    [SerializeField]
    private HeroClass HeroClass;

    [SerializeField]
    private int Damage;

    [SerializeField]
    private int Attack;

    [SerializeField]
    private int ArrowDamage;

    void Update()
    {
        Debug.Log("Update");
    }

    public void Move()
    {
        transform.position += Vector3.forward;
    }
}
