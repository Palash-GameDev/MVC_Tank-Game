using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
    public List<Tank> tanksList;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void CreateTank(TankTypes tankTypes)
    {
        if (tankTypes == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(tanksList[1].movementSpeed, tanksList[1].rotationSpeed, tanksList[1].tankTypes, tanksList[1].materialColor);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if (tankTypes == TankTypes.RedTank)
        {
             TankModel tankModel = new TankModel(tanksList[2].movementSpeed, tanksList[2].rotationSpeed, tanksList[2].tankTypes, tanksList[2].materialColor);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if (tankTypes == TankTypes.GreenTank)
        {
             TankModel tankModel = new TankModel(tanksList[0].movementSpeed, tanksList[0].rotationSpeed, tanksList[0].tankTypes, tanksList[0].materialColor);
            TankController tankController = new TankController(tankModel, tankView);
        }

    }



    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankTypes;

        public Material materialColor;
    }
}
