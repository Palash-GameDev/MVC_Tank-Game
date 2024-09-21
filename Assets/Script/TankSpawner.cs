using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
    public List<Tank> tanksList ;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }
    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tanksList[2].movementSpeed, tanksList[2].rotationSpeed, tanksList[2].tankTypes, tanksList[2].materialColor);
        TankController tankController = new TankController(tankModel, tankView);
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
