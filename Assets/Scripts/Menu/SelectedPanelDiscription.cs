using UnityEngine;
using UnityEngine.UI;

public class SelectedPanelDiscription : MonoBehaviour
{
    public void Init()
    {
        EventBus.OnInfoCharacter += SetImageAndText;
    }

    private void OnDestroy()
    {
        EventBus.OnInfoCharacter -= SetImageAndText;
    }

    private void SetImageAndText(PanelDiscription discription)
    {
        transform.GetChild(0).GetComponent<Image>().sprite = discription.Info.Character;
        transform.GetChild(1).GetComponent<Localize>().LocalizationKey = discription.Info.Discription;
        transform.GetChild(1).GetComponent<Localize>().UpdateLocale();
    }
}


