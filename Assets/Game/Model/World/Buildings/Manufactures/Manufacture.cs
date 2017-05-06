using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Manufacture", menuName = "Buildings/Manufature", order = 1)]
[System.Serializable]
public class Manufacture : SceneObjectBase {
    public ManufactureType ManufactureType { get; set; }

    public override void OnClick()
    {
        throw new NotImplementedException();
    }
    public string Name { get; set; }    
    public string Text { get; set; }
}
