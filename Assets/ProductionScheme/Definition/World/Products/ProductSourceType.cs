using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProducSourceType", menuName = "World/Product/ProductSourceType", order = 1)]
public class ProductSourceType : ScriptableObject {
    public string Name;
    public string Text;

    public ProductType ProductType;
}
