using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Info", menuName = "Info/Enemy")]
public class EnemySO : ScriptableObject
{
    [SerializeField] private Sprite _spriteEnemy;
    [SerializeField] private float _speed;
    [SerializeField] private float _damage;
    [SerializeField] private float _maxHP;

    public Sprite SpriteEnemy { get => _spriteEnemy;  }
    public float Speed { get => _speed;  }
    public float Damage { get => _damage;  }
    public float MaxHP { get => _maxHP;  }
}
