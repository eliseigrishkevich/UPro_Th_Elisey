using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Controll inputActions;

    private Vector2 _oldTargetMove = Vector2.up;

    public void Init()
    {
        inputActions = new Controll();
        inputActions.Enable();

        _rb = GetComponent<Rigidbody2D>();

        EventBus.OnControll += GetControll;
        EventBus.OnPositionCharacter += GetPositionCharacter;
    }


    private void FixedUpdate()
    {
        _rb.AddForce(inputActions.Character.Move.ReadValue<Vector2>() * 5);
    }
    private Vector3 GetPositionCharacter(byte arg)
    {
        return transform.position;
    }

    private Vector2 GetControll(byte arg)
    {
        if (inputActions.Character.Move.ReadValue<Vector2>() != Vector2.zero)
            _oldTargetMove = inputActions.Character.Move.ReadValue<Vector2>();

        return _oldTargetMove;

    }

    private void OnDestroy()
    {
        EventBus.OnControll -= GetControll;
        EventBus.OnPositionCharacter -= GetPositionCharacter;
    }
}
