using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambulance : Car
{
    

    public override void OnEnable()
    {
        brSO.greenEvent += Acelerate;
    }
    public override void OnDisable()
    {
        brSO.greenEvent -= Acelerate;
    }

    public override void Acelerate()
    {
        base.Acelerate();
        ICarSmoke icarSmoke= (ICarSmoke)icarState;
        icarSmoke.ThrowSmoke();
        
    }


}