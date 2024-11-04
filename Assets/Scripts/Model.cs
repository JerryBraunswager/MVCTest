using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private float _price;
    [SerializeField] private float _discountAmount;

    public string Name => _name;
    public float Price => _price;
    public double DiscountPrice => Math.Round(_price * (1 - _discountAmount),2);
}
