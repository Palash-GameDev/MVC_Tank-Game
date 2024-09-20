using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    private TankModel tankModel;
    private TankView tankView;


    public TankController(TankModel _tankmodel, TankView _tankview)
    {
        tankModel = _tankmodel;
        tankView = _tankview;

        tankView.SetTankController(this);
        tankModel.SetTankController(this);
        
        GameObject.Instantiate(tankView.gameObject);
    }
}// end class
