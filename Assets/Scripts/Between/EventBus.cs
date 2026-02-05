using System;
using UnityEngine;



/* 4 важных момента:
1)static имеет постояннын айди
2)auction-послежний параметр это то чот передает funk
*/
public class EventBus : MonoBehaviour
{
    public static Action<PanelDiscription> OnInfoCharacter;
    public static Action<InfoWeapon> OnAddWeapon;
    public static Action<GameObject> OnWeaponDes;

    public static Action<float> AOnSubHPCharactre;
    public static Func<byte, float> FOnGetHPCharactre;

    public static Action<float> AOnSpeedCharacter;
    public static Action<float> AOnAddTimeDurationWeapon;
    public static Action<float> AOnAddTimeSpeedWeapon;
    public static Action<float> AOnAddTimeCreateEnemies;

    public static Func<byte, Vector2> OnControll;
    public static Func<byte, Vector3> OnPositionCharacter;

    public static Func<byte, float> FOnSpeedCharacter;
    public static Func<byte, float> FOnAddTimeDurationWeapon;
    public static Func<byte, float> FOnAddTimeSpeedWeapon;
    public static Func<byte, float> FOnAddTimeCreateEnemies;
}


