using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "StorageType", menuName = "Buildings/StorageType", order = 1)]
public class StorageType : ScriptableObject {
    public string Name;
    public string Text;

    public List<ProductType> StorableTypes;
}
