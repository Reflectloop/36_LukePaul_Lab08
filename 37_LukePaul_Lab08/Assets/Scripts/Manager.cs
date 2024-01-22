using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public float SGDUSD = 0.74f;
    public float SGDJPY = 82.78f;
    public float SGDRM = 3.08f;
    public float SGDEUR = 0.63f;
    public float SGDKRW = 881.54f;
    public float SGDTWD = 20.73f;

    public int COUNTER;
    public int numOFTick;

    public float value;

    public Toggle[] allToggle;

    float SGDAmount;

    public InputField thxamount;

    public Text ConvertedAmount;
    public Text Error;

    // Start is called before the first frame update
    void Start()
    {
        Error.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void convertamount()
    {
        numOFTick = 0;
        try
        {
          SGDAmount = float.Parse(thxamount.text);
            for (int i = 0; i < allToggle.Length; i++)
            {
               
                if (allToggle[i].isOn == true)
                {
                    numOFTick++;
                }
                if (numOFTick > 1)
                {
                    Error.gameObject.SetActive(true);
                    Error.text = "Choose one only 1";
                    return;
                }

            }
           

                if (allToggle[0].isOn == true)
                {
                     Error.gameObject.SetActive(false);
                     value = SGDAmount * SGDUSD;
                    ConvertedAmount.text = "$" + value.ToString() + " USD";

                }

                if (allToggle[1].isOn == true)
                {
                    Error.gameObject.SetActive(false);
                    value = SGDAmount * SGDJPY;
                    ConvertedAmount.text = "$" + value.ToString() + " JPY";
                }
                if (allToggle[2].isOn == true)
                {
                       Error.gameObject.SetActive(false);
                   value = SGDAmount * SGDRM;
                    ConvertedAmount.text =  value.ToString() + "RINGGIT";

                }
            if (allToggle[3].isOn == true)
            {
                Error.gameObject.SetActive(false);
                value = SGDAmount * SGDEUR;
               ConvertedAmount.text = value.ToString() + "EUR";
            }
            if (allToggle[4].isOn == true)
            {
                Error.gameObject.SetActive(false);
                value = SGDAmount * SGDKRW;
                ConvertedAmount.text = value.ToString() + "KRW";
            }
            if (allToggle[5].isOn == true)
            {
                Error.gameObject.SetActive(false);
                value = SGDAmount * SGDTWD;
                ConvertedAmount.text = value.ToString() + "TWD";
            }
        }
        catch
        {
            Error.gameObject.SetActive(true);
            Error.text = "INPUT ERROR ";



        }
       
       

    }
    public void clear()
    {
        thxamount.text = "";
        ConvertedAmount.text = "";
        for (int i = 0; i < allToggle.Length; i++)
        {
            allToggle[i].isOn = false;

        }

    }
}
