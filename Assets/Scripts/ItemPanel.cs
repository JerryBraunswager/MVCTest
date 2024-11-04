using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemPanel : MonoBehaviour
{
    [SerializeField] private Item _item;
    [SerializeField] private Image _spriteRenderer;
    [SerializeField] private TMP_Text _text;

    private void Awake()
    {
        _spriteRenderer.sprite = _item.Sprite;
        _text.text = _item.Name;
    }
}
