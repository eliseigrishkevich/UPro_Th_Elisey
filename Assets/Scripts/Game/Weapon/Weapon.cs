using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private InfoWeapon infoWeapon;

    public InfoWeapon InfoWeapon { get => infoWeapon; set => infoWeapon = value; }

    public void Init()
    {

    }
}
