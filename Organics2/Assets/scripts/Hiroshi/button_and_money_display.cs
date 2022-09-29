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
    // for random break
    public double clickCount;
    private int fakeRandomNumber;
    public GameObject PayButton1;
    public GameObject PayButton2;
    public GameObject PayButton3;
    public GameObject PayButton4;
    public GameObject PayButton5;

    employees Employ;

    // Start is called before the first frame update
    void Start()
    {
        e.SetActive(false);
        a.SetActive(false);
        r.SetActive(false);
        t.SetActive(false);
        h.SetActive(false);
        //for random break
        clickCount = 0.00f;
        PayButton1.SetActive(false);
        PayButton2.SetActive(false);
        PayButton3.SetActive(false);
        PayButton4.SetActive(false);
        PayButton5.SetActive(false);

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
        if (clickCount <= 10)
        {
            money += 5;
        }
        else
        {
        
        }
    }

    public void FishGallon()
    {
        if (clickCount <= 10)
        {
            money += 20;
        }
        else
        {
  
        }
    }

    public void FishTwoAndAHalf()
    {
        if (clickCount <= 10)
        {
            money += 50;
        }
        else
        {
           
        }
    }

    public void FishBuckets()
    {
        if (clickCount <= 10)
        {
            money += 100;
        }
        else
        {
           
        }
    }

    public void FishBarrel()
    {
        if (clickCount <= 10)
        {
            money += 1100;
        }
        else
        {
           
        }

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

    //try to use random range between 1 through 5 but failed.
   private void Break1()
    {
        PayButton1.SetActive(true);
    }
    private void Break2()
    {
        PayButton2.SetActive(true);
    }
    private void Break3()
    {
        PayButton3.SetActive(true);
    }
    private void Break4()
    {
        PayButton4.SetActive(true);
    }
    private void Break5()
    {
        PayButton5.SetActive(true);
    }
    public void PaytoFix()
    {

        if (money >= 750)
        {
            money -= 750;
            PayButton1.SetActive(false);
            Debug.Log("paid");
        }

        else
        {
            money = 0.00f;
            Debug.Log("bankrupted");
        }
    }
}
