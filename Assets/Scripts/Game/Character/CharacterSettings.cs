using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSettings : MonoBehaviour
{
    private float _speedCharacter = 1;
    private float _addTimeDurationWeapon = 0;
    private float _addTimeSpeedWeapon = 1;
    private float _addTimeCreateEnemies = 0;

    private float _hp;

    public void Init(float HP)
    {
        EventBus.FOnSpeedCharacter += GetSpeed;
        EventBus.FOnAddTimeDurationWeapon += GetTDW;
        EventBus.FOnAddTimeSpeedWeapon += GetTSW;
        EventBus.FOnAddTimeCreateEnemies += GetTCE;

        EventBus.AOnSpeedCharacter += AddSpeed;
        EventBus.AOnAddTimeDurationWeapon += AddTDW;
        EventBus.AOnAddTimeSpeedWeapon += AddTSW;
        EventBus.AOnAddTimeCreateEnemies += AddTCE;

        EventBus.AOnSubHPCharactre += SetHP;
        EventBus.FOnGetHPCharactre += GetHP;

        _hp = HP;

        
    }

    private IEnumerator LoadScene()
    {
        yield return Load.Instance.LoadScene(1);
    }

    private float GetHP(byte arg)
    {
        return _hp;
    }

    private void SetHP(float damage)
    {
        _hp -= damage;

        if (_hp <= 0)
            StartCoroutine(LoadScene());
    }

    private void AddTCE(float obj)
    {
        _addTimeCreateEnemies += 0.2f;
    }

    private void AddTSW(float obj)
    {
        _addTimeDurationWeapon += 0.2f;
    }

    private void AddTDW(float obj)
    {
        _addTimeDurationWeapon += 0.2f;
    }

    private void AddSpeed(float obj)
    {
        _speedCharacter += 1f;
    }

    private float GetSpeed(byte arg)
    {
        return _speedCharacter;
    }

    private float GetTSW(byte arg)
    {
        return _addTimeDurationWeapon;
    }

    private float GetTDW(byte arg)
    {
        return _addTimeSpeedWeapon;
    }

    private float GetTCE(byte arg)
    {
       return _addTimeCreateEnemies;
    }

    private void OnDestroy()
    {
        
    }
}
