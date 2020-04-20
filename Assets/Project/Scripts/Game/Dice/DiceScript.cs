using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceScript : MonoBehaviour
{

    public Rigidbody rb;
    public Vector3 startPos;
    public Text text;
    public int diceNumber;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void RollDice()
    {
        text.text = "Dice " + diceNumber + ":";
        float dirX = Random.Range(-1000, 1000);
        float dirY = Random.Range(-1000, 1000);
        float dirZ = Random.Range(-1000, 1000);
        transform.position = new Vector3(Random.Range(-2, 2), Random.Range(2, 4), Random.Range(-2, 2)) ;
        transform.rotation = new Quaternion(dirX, dirY, dirZ, 1);
        rb.AddForce(transform.up * Random.Range(500, 800));
        rb.AddTorque(dirX, dirY, dirZ);
    }
}
