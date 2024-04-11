using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BetBeh : MonoBehaviour
{
    [SerializeField] Image buttonStart;
    [SerializeField] Sprite buttonGreen;
    [SerializeField] Sprite buttonGrey;
    [SerializeField] Sprite buttonOrange;
    [SerializeField] Sprite buttonPurple;
    [SerializeField] Button button10;
    [SerializeField] Button button25;
    [SerializeField] Button button50;
    [SerializeField] Button button100;
    [SerializeField] Button button250;
    [SerializeField] Button button500;
    [SerializeField] TextMeshProUGUI textBetAmountOutput;
    [SerializeField] BJSystem bJSystem;

    public int betAmount { get; private set; }
    public bool isBetReady { get; set; }

    public void betButton10Pushed()
    {
        if (bJSystem.balance >= 10)
        {
            isBetReady = true;
            button10.GetComponent<Image>().sprite = buttonOrange;
            button25.GetComponent<Image>().sprite = buttonPurple;
            button50.GetComponent<Image>().sprite = buttonPurple;
            button100.GetComponent<Image>().sprite = buttonPurple;
            button250.GetComponent<Image>().sprite = buttonPurple;
            button500.GetComponent<Image>().sprite = buttonPurple;

            buttonStart.sprite = buttonGreen;
            betAmount = 10;
            textBetAmountOutput.text = betAmount.ToString();
        }
    }

    public void betButton25Pushed()
    {
        if (bJSystem.balance >= 25)
        {
            isBetReady = true;
            button10.GetComponent<Image>().sprite = buttonPurple;
            button25.GetComponent<Image>().sprite = buttonOrange;
            button50.GetComponent<Image>().sprite = buttonPurple;
            button100.GetComponent<Image>().sprite = buttonPurple;
            button250.GetComponent<Image>().sprite = buttonPurple;
            button500.GetComponent<Image>().sprite = buttonPurple;

            buttonStart.sprite = buttonGreen;
            betAmount = 25;
            textBetAmountOutput.text = betAmount.ToString();
        }
    }

    public void betButton50Pushed()
    {
        if (bJSystem.balance >= 50)
        {
            isBetReady = true;
            button10.GetComponent<Image>().sprite = buttonPurple;
            button25.GetComponent<Image>().sprite = buttonPurple;
            button50.GetComponent<Image>().sprite = buttonOrange;
            button100.GetComponent<Image>().sprite = buttonPurple;
            button250.GetComponent<Image>().sprite = buttonPurple;
            button500.GetComponent<Image>().sprite = buttonPurple;

            buttonStart.sprite = buttonGreen;
            betAmount = 50;
            textBetAmountOutput.text = betAmount.ToString();
        }
    }

    public void betButton100Pushed()
    {
        if (bJSystem.balance >= 100)
        {
            isBetReady = true;
            button10.GetComponent<Image>().sprite = buttonPurple;
            button25.GetComponent<Image>().sprite = buttonPurple;
            button50.GetComponent<Image>().sprite = buttonPurple;
            button100.GetComponent<Image>().sprite = buttonOrange;
            button250.GetComponent<Image>().sprite = buttonPurple;
            button500.GetComponent<Image>().sprite = buttonPurple;

            buttonStart.sprite = buttonGreen;
            betAmount = 100;
            textBetAmountOutput.text = betAmount.ToString();
        }
    }

    public void betButton250Pushed()
    {
        if (bJSystem.balance >= 250)
        {
            isBetReady = true;
            button10.GetComponent<Image>().sprite = buttonPurple;
            button25.GetComponent<Image>().sprite = buttonPurple;
            button50.GetComponent<Image>().sprite = buttonPurple;
            button100.GetComponent<Image>().sprite = buttonPurple;
            button250.GetComponent<Image>().sprite = buttonOrange;
            button500.GetComponent<Image>().sprite = buttonPurple;

            buttonStart.sprite = buttonGreen;
            betAmount = 250;
            textBetAmountOutput.text = betAmount.ToString();
        }
    }

    public void betButton500Pushed()
    {
        if (bJSystem.balance >= 500)
        {
            isBetReady = true;
            button10.GetComponent<Image>().sprite = buttonPurple;
            button25.GetComponent<Image>().sprite = buttonPurple;
            button50.GetComponent<Image>().sprite = buttonPurple;
            button100.GetComponent<Image>().sprite = buttonPurple;
            button250.GetComponent<Image>().sprite = buttonPurple;
            button500.GetComponent<Image>().sprite = buttonOrange;

            buttonStart.sprite = buttonGreen;
            betAmount = 500;
            textBetAmountOutput.text = betAmount.ToString();
        }
    }

    public void AllButtonPurple()
    {
        button10.GetComponent<Image>().sprite = buttonPurple;
        button25.GetComponent<Image>().sprite = buttonPurple;
        button50.GetComponent<Image>().sprite = buttonPurple;
        button100.GetComponent<Image>().sprite = buttonPurple;
        button250.GetComponent<Image>().sprite = buttonPurple;
        button500.GetComponent<Image>().sprite = buttonPurple;
    }
}
