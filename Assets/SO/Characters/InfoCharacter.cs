using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Info", menuName = "Info/Character")]
public class InfoCharacter : ScriptableObject
{
    [SerializeField]
    private Sprite _character;
    [SerializeField]
    private Sprite _baseWeapon;
    [SerializeField]
    private string _discription;
    [SerializeField]
    private InfoWeapon _prefabWeapon;
    [SerializeField]
    private float _maxHP;

    public Sprite Character { get => _character; }
    public Sprite BaseWeapon { get => _baseWeapon; }
    public string Discription { get => _discription; }
    public InfoWeapon PrefabWeapon { get => _prefabWeapon; }
    public float MaxHP { get => _maxHP; }
}
