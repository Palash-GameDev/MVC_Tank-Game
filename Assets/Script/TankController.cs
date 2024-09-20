using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rbTank;


    public TankController(TankModel _tankmodel, TankView _tankview)
    {
        tankModel = _tankmodel;
        tankView = GameObject.Instantiate<TankView>(_tankview);
        rbTank = tankView.GetRigidbody();

        tankView.SetTankController(this);
        tankModel.SetTankController(this);
    }


    public void Move(float movement, float movementSpeed)
    {
        rbTank.velocity = tankView.transform.forward * movement * movementSpeed;
    }
    public void Rotate(float rotate, float rotationSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotationSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rbTank.MoveRotation(rbTank.rotation * deltaRotation);
    }


    public TankModel GetTankModel()
    {
        return tankModel;
    }









}// end class
