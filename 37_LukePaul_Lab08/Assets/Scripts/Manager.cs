using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public float SGDUSD = 0.74f;
    public float SGDJPY = 82.78f;
    public float value;

    public Toggle SGD2USD;
    public Toggle SGD2JPY;

    float SGDAmount;

    public InputField thxamount;

    public Text ConvertedAmount;
    public Text Error;
    // Start is called before the first frame update
    void Start()
    {
        Error.gameObject.SetActive(false);
        SGD2USD.isOn = false;
        SGD2JPY.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void convertamount()
    {
        SGDAmount = float.Parse(thxamount.text);

        if (SGD2USD.GetComponent<Toggle>().isOn == true && SGD2JPY.GetComponent<Toggle>().isOn == false)
        {
            Error.gameObject.SetActive(false);
            value = SGDAmount * SGDUSD;
            ConvertedAmount.text = "$" + value.ToString() + " USD";
        }
        if (SGD2JPY.GetComponent<Toggle>().isOn == true && SGD2USD.GetComponent<Toggle>().isOn == false)
        {
            Error.gameObject.SetActive(false);
            value = SGDAmount * SGDJPY;
            ConvertedAmount.text = "¥" + value.ToString() + " JPY";
        }
        if (SGD2JPY.GetComponent<Toggle>().isOn == true && SGD2USD.GetComponent<Toggle>().isOn == true)
        {
            Error.gameObject.SetActive(true);
            Error.text = "Invalid Please Tick 1 ";
        }

    }
    public void clear()
    {
        thxamount.text = "";
        ConvertedAmount.text = "";

        SGD2USD.isOn = false;
        SGD2JPY.isOn = false;
    }
}
