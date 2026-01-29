using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Info", menuName = "Info/Wave")]
public class Wave : ScriptableObject
{
    [SerializeField] private float _duraction;
    [SerializeField] private float _timeBetweenSpawn;
    [SerializeField] private List<EnemySO> _enemies;

    public float Duraction { get => _duraction; }
    public float TimeBetweenSpawn { get => _timeBetweenSpawn; }
    public List<EnemySO> Enemies { get => _enemies; }
}
