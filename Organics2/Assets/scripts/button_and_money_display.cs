using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_and_money_display : MonoBehaviour
{
    public double money = 0.00f;
    public Text moneyText;
    public Text noMoney;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayMoney();

        // employee making money
        //if()
        //{
            //FishQuater();
        //}

        
    }

    // buttons to earn money
    public void FishQuater()
    {
        money += 5;
    }

    public void FishGallon()
    {
        money += 20.78;
    }

    public void FishTwoAndAHalf()
    {
        money += 50;
    }

    public void FishBuckets()
    {
        money += 100;
    }

    public void FishBarrel()
    {
        money += 1100;
    }

    public void DisplayMoney()
    {
        moneyText.text = "$ " + money;
    }

    // buttons to hire employees
    public void EmployeeOne()
    {
        if (money >= 750)
        {
            money -= 750;
        }
        /*
        else
        {
            noMoney.text = "You don't have enough money!";
        }
        */
    }

    public void EmployeeTwo()
    {
        if (money >= 1500)
        {
            money -= 1500;
        }
        /*
        else
        {
            noMoney.text = "You don't have enough money!";
        }
        */
    }

    public void EmployeeThree()
    {
        if (money >= 2300)
        {
            money -= 2300;
        }
        /*
        else
        {
            noMoney.text = "You don't have enough money!";
        }
        */
    }

    public void EmployeeFour()
    {
        if (money >= 3000)
        {
            money -= 3000;
        }
        /*
        else
        {
            noMoney.text = "You don't have enough money!";
        }
        */
    }

    public void EmployeeFive()
    {
        if (money >= 3800)
        {
            money -= 3800;
        }
        /*
        else
        {
            noMoney.text = "You don't have enough money!";
        }
        */
    }
}
