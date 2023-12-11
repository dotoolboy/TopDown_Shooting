using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum StatChangeType
{
    Add,
    Multiple,
    Override,
}

[Serializable]
public class CharacterStats
{
    public StatChangeType statsChangeType;
    [Range(0, 100)] public int maxHealth;
    [Range(1f, 20f)] public float speed;

    // 공격 데이터
    public AttackSO attackSO;
}

