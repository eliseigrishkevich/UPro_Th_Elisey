using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCharacter : Singleton<SaveCharacter>
{
    [SerializeField] //просто чтобы убедиться что переменная в инспектора
    InfoCharacter _currentCharacter;

    public InfoCharacter CurrentCharacter { get => _currentCharacter; }//свойство 

    public void Init()
    {
        EventBus.OnInfoCharacter += SetCurrentCharacter;//подписываемся
    }

    private void SetCurrentCharacter(PanelDiscription panel)//параметры должны совпадатьс delegate
    {
        _currentCharacter = panel.Info; //передаем панель  
    }

    public override void OnDestroy()
    {
        base.OnDestroy();
        EventBus.OnInfoCharacter -= SetCurrentCharacter;//отписываемся
    }
}


