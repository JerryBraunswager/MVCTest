using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Translater : MonoBehaviour
{
    [SerializeField] private Controller _controller;

    private Button _button;

    public event UnityAction<Translater> ButtonClicked;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _controller.AddButton(this);
        _button.onClick.AddListener(Click);
    }

    private void OnDisable()
    {
        _controller.RemoveButton(this);
        _button.onClick.RemoveListener(Click);
    }

    private void Click()
    {
        ButtonClicked?.Invoke(this);
    }
}
