using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float movementSpeed;
    public TankTypes tankType;
    public Material color;
    public float rotationSpeed;
    public TankModel(float _movement, float _rotation,TankTypes _tankTypes,Material _color)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
        tankType = _tankTypes;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

}//  end class
