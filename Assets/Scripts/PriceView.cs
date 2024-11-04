using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PriceView : MonoBehaviour
{
    [SerializeField] private Controller _controller;
    [SerializeField] private TMP_Text _discountPriceText;
    [SerializeField] private TMP_Text _priceText;

    private void Start()
    {
        _discountPriceText.text = _controller.DiscountPrice;
        _priceText.text = _controller.Price;
    }
}
