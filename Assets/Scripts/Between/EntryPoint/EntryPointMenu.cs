using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointMenu : MonoBehaviour
{
    [SerializeField]
    private PanelDiscription _prefabPanel;
    [SerializeField]
    private List<InfoCharacter> _characterList;
    [SerializeField]
    private CreatePanelDiscription createPanelDiscription;

    [SerializeField] 
    private SetLanguageLocalization sll;
    void Awake()
    {
        CSVReader.LoadCSV();
        sll.Init();

        ObjectsPool.Instance.AddObjects<PanelDiscription>(_prefabPanel, 10);

        SaveCharacter.Instance.Init();

        FindObjectOfType<SelectedPanelDiscription>().Init();

        createPanelDiscription.Create(_characterList);

    }
}
