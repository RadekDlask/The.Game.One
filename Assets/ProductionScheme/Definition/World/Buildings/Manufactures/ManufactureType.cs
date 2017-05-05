using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ManufactureType", menuName = "Buildings/ManufactureType", order = 1)]
public class ManufactureType : ScriptableObject {
    public string Name;
    public string Text;

    public List<ProductType> Inputs;
    public List<ProductType> Outputs;
}
