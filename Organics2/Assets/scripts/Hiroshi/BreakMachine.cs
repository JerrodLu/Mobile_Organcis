using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RBreakMachine : MonoBehaviour
{
    public GameObject SellButton;
    public GameObject PayButton;
    private double money = 0.00f;
   // public Text moneyText;
    public double clickCount;

    void Start()
    {
        clickCount = 0.00f;
        PayButton.SetActive(false);
    }

    void Update()
    {
       // DisplayMoney();
        CountPlayerClick();

    }
    public void RandomChoice()
    {

    }
    public void Break()
    {
        if (clickCount >= 10)
        {
            SellButton.SetActive(false);
            PayButton.SetActive(true);
            Debug.Log("Break!");
        }
    }

    public void PaytoFix()
    {

        if (money >= 750)
        {
            money -= 750;
            PayButton.SetActive(false);
            SellButton.SetActive(true);
            Debug.Log("pay");
        }

        else
        {
            money = 0.00f;
            Debug.Log("no money");
        }
    }
    public void CountPlayerClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount += 1;
        }
    }

    /*
    //testing
    public void SellBottoles()
    {
        if (clickCount <= 10)
        {
            money += 500;
        }
        else
        {
            Break();
        }
    }

    //testing
    public void DisplayMoney()
    {
        moneyText.text = "$ " + money;
    }
    */
}
