using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProducType", menuName = "World/Product/ProductType", order = 1)]
public class ProductType : ScriptableObject {
    public string Name;
    public string Text;
}
