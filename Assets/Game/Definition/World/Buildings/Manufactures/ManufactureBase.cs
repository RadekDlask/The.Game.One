using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ManufactureBase : BuildingBase {
    public ManufactureType ManufactureType { get; set; }

    public override void OnClick()
    {
        throw new NotImplementedException();
    }
}
