using UnityEngine;

public class PanelShow : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _button;

    public void ShowPanel()
    {
        _panel.SetActive(true);
        _button.SetActive(false);
    }
}
