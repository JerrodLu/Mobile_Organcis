using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_and_money_display : MonoBehaviour
{
    public GameObject e;//employee 
    public GameObject a;//employee 
    public GameObject r;//employee 
    public GameObject t;//employee 
    public GameObject h;//employee 
    public float money = 0.0f;
    public float netMoney = 0.0f;
    public Text moneyText;
    //public Text noMoney;
    employees other;
    //public GameObject backColorText;
    //public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        e.SetActive(false);
        a.SetActive(false);
        r.SetActive(false);
        t.SetActive(false);
        h.SetActive(false);
        //moneyText.text = money.ToString("C2");
        //noMoney.enabled = false;
        //backColorText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        DisplayMoney();
        Hired();
    }

    // buttons to earn money
    public void FishQuater()
    {
        money += 5;
        netMoney += 5;
    }

    public void FishGallon()
    {
        money += 20;
        netMoney += 20;
    }

    public void FishTwoAndAHalf()
    {
        money += 50;
        netMoney += 50;
    }

    public void FishBuckets()
    {
        money += 100;
        netMoney += 100;
    }

    public void FishBarrel()
    {
        money += 1100;
        netMoney += 1100;
    }

    public void DisplayMoney()
    {
        moneyText.text = money.ToString("C2");
    }

    // buttons to hire employees
    public void EmployeeOne()
    {
        if (money >= 750)
        {
            Debug.Log("why");
            money -= 750;
            e.SetActive(true);
        }
        else
        {
            //noMoney.enabled = true;
            //backColorText.SetActive(true);
            //noMoney.text = "You don't have enough money!";
        }
    }

    public void EmployeeTwo()
    {
        if (money >= 1500)
        {
            money -= 1500;
            a.SetActive(true);
        }
        else
        {
            //noMoney.enabled = true;
            //backColorText.SetActive(true);
            //noMoney.text = "You don't have enough money!";
        }
    }

    public void EmployeeThree()
    {
        if (money >= 2300)
        {
            money -= 2300;
            r.SetActive(true);
        }
        else
        {
            //noMoney.enabled = true;
            //backColorText.SetActive(true);
            //noMoney.text = "You don't have enough money!";
        }
    }

    public void EmployeeFour()
    {
        if (money >= 3000)
        {
            money -= 3000;
            t.SetActive(true);
        }
        else
        {
            //noMoney.enabled = true;
            //backColorText.SetActive(true);
            //noMoney.text = "You don't have enough money!";
        }
    }

    public void EmployeeFive()
    {
        if (money >= 3800)
        {
            money -= 3800;
            h.SetActive(true);
        }
        else
        {
            //noMoney.enabled = true;
            //backColorText.SetActive(true);
            //noMoney.text = "You don't have enough money!";
        }
    }

    // Employee running the machine
    public void Hired()
    {
        if (e.activeInHierarchy == true)
        {
            FishQuater();
        }
        if (a.activeInHierarchy == true)
        {
            FishGallon();
        }
        if (r.activeInHierarchy == true)
        {
            FishTwoAndAHalf();
        }
        if (t.activeInHierarchy == true)
        {
            FishBuckets();
        }
        if (h.activeInHierarchy == true)
        {
            FishBarrel();
        }
    }
}
