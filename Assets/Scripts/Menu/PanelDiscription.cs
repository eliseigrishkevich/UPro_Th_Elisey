using UnityEngine;
using UnityEngine.UI;

public class PanelDiscription : MonoBehaviour
{
    InfoCharacter _info;

    public InfoCharacter Info { get => _info; } //свойство


    private void OnDestroy()
    {
        EventBus.OnInfoCharacter -= SetBackground;//отписываемся
    }

    public void Spawn(InfoCharacter character)
    {
        _info = character;

        transform.GetChild(0).GetComponent<Image>().sprite = _info.Character;
        transform.GetChild(1).GetComponent<Localize>().LocalizationKey = _info.Discription;
        transform.GetChild(2).GetComponent<Image>().sprite = _info.BaseWeapon;

        GetComponent<Button>().onClick.AddListener(() =>
        {
            EventBus.OnInfoCharacter?.Invoke(this);//проверяем на подписку
        });

        GetComponent<RectTransform>().localScale = Vector3.one;
        GetComponent<RectTransform>().position = new Vector3(transform.position.x, transform.position.y, 0);
        EventBus.OnInfoCharacter += SetBackground;//подписывемся
    }

    private void SetBackground(PanelDiscription panel)
    {
        if (panel == this)
            transform.GetComponent<Image>().color = new Color(0.7169812f, 0.7169812f, 0.7169812f, 1);
        else
            transform.GetComponent<Image>().color = new Color(0f, 0.03654854f, 0.3490196f, 1);
    }
}


