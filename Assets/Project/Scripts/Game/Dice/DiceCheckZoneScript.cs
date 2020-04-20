using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceCheckZoneScript : MonoBehaviour
{
    private Vector3 dice1Velocity;
    private Vector3 dice2Velocity;
    private Vector3 dice3Velocity;
    private Vector3 dice4Velocity;
    private Vector3 dice5Velocity;
    private Vector3 dice6Velocity;

    public Text lblDice1;
    public Text lblDice2;
    public Text lblDice3;
    public Text lblDice4;
    public Text lblDice5;
    public Text lblDice6;

    // Start is called before the first frame update
    private void FixedUpdate()
    {

    }

    // Update is called once per frame
    private void OnTriggerStay(Collider dice)
    {
        //var rb = dice.gameObject.transform.parent.GetComponent<Rigidbody>();

        var rb = 1;
        if (rb == 1)
        {
            switch(dice.gameObject.name)
            {
                case "Side1":
                    SetLabelText(dice.gameObject.transform.parent.name, 1);
                    break;
                case "Side2":
                    SetLabelText(dice.gameObject.transform.parent.name, 2);
                    break;
                case "Side3":
                    SetLabelText(dice.gameObject.transform.parent.name, 3);
                    break;
                case "Side4":
                    SetLabelText(dice.gameObject.transform.parent.name, 4);
                    break;
                case "Side5":
                    SetLabelText(dice.gameObject.transform.parent.name, 5);
                    break;
                case "Side6":
                    SetLabelText(dice.gameObject.transform.parent.name, 6);
                    break;
            }
        }
    }

    private void SetLabelText(string diceName, int side)
    {
        
        switch(diceName)
        {
            case "Dice 1":
                lblDice1.text = diceName + ": " + side;
                break;
            case "Dice 2":
                lblDice2.text = diceName + ": " + side;
                break;
            case "Dice 3":
                lblDice3.text = diceName + ": " + side;
                break;
            case "Dice 4":
                lblDice4.text = diceName + ": " + side;
                break;
            case "Dice 5":
                lblDice5.text = diceName + ": " + side;
                break;
            case "Dice 6":
                lblDice6.text = diceName + ": " + side;
                break;
        }
    }
}
