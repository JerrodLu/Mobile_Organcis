using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBreak : MonoBehaviour
{
    public double clickCount;
    public GameObject PayButton1;
    public GameObject PayButton2;
    public GameObject PayButton3;
    public GameObject PayButton4;
    public GameObject PayButton5;
    // Start is called before the first frame update
    void Start()
    {
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
        CountPlayerClick();
    }

    public void CountPlayerClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount += 1;
        }
    }
    public void Break()
    {
        if (clickCount >= 5)
        {
            PayButton1.SetActive(true);
            Debug.Log("Break!");
        }
    }
}
