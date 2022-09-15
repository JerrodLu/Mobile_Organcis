using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_and_money_display : MonoBehaviour
{
    public double money = 0.00f;
    public Text moneyText;
    //public Text noMoney;
    public GameObject canvas;
    public GameObject e;
    public GameObject a;
    public GameObject r;
    public GameObject t;
    public GameObject h;

    employees Employ;

    // Start is called before the first frame update
    void Start()
    {
        e.SetActive(false);
        a.SetActive(false);
        r.SetActive(false);
        t.SetActive(false);
        h.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        DisplayMoney();

        // employee making money
        if (e.activeInHierarchy == true)
        {
            FishQuater();
        }
        else if (a.activeInHierarchy == true)
        {
            FishGallon();
        }
        else if (r.activeInHierarchy == true)
        {
            FishTwoAndAHalf();
        }
        else if (t.activeInHierarchy == true)
        {
            FishBuckets();
        }
         else if (h.activeInHierarchy == true)
        {
            FishBarrel();
        }
    }

    // buttons to earn money
    public void FishQuater()
    {
        money += 5;
    }

    public void FishGallon()
    {
        money += 20;
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
            e.SetActive(true);
        }
        
        else
        {
            
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
            r.SetActive(true);
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
            t.SetActive(true);
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
            h.SetActive(true);
        }
        /*
        else
        {
            noMoney.text = "You don't have enough money!";
        }
        */
    }
}
