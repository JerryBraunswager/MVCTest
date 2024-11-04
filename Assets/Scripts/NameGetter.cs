using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class NameGetter : MonoBehaviour
{
    [SerializeField] private Controller _controller;

    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        _text.text = _controller.Name;
    }
}
