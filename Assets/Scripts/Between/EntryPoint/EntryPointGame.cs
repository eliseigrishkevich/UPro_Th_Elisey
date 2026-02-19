using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointGame : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefabCharacter;
    [SerializeField]
    private CameraMove _camera;
    

    void Start()
    {
        GameObject character = Instantiate(_prefabCharacter, Vector3.zero, Quaternion.identity);
        character.GetComponent<CharacterInit>().Init();

        _camera.Init(character.transform);
    }
}
