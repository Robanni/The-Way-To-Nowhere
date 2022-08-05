using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new EnemyData", menuName = "EnemyData", order = 51)]
public class EnemyData : ScriptableObject
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int damage;
    [SerializeField] private float attackRange;
    [SerializeField] private Sprite sprite;

    public int MaxHealth { get { return maxHealth; }}
    public int Damage { get { return damage; }}
    public float AttackRange { get { return attackRange; }}
    public Sprite Sprite { get { return sprite; }}
}
