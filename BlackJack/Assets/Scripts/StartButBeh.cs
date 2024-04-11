using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BJSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI balanceText;
    [SerializeField] TextMeshProUGUI totalWinText;
    [SerializeField] Image buttonImage;
    [SerializeField] Sprite buttonGreen;
    [SerializeField] Sprite buttonGrey;

    [SerializeField] Sprite[] spades;
    [SerializeField] Sprite[] hearts;
    [SerializeField] Sprite[] diamonds;
    [SerializeField] Sprite[] crosses;

    [SerializeField] Image cart1;
    [SerializeField] Image cart2;
    [SerializeField] Image cart3;
    [SerializeField] Image cart4;

    [SerializeField] BetBeh betBeh;

    public int scoresPlayer { get; private set; }
    public int scoresDealer { get; private set; }
    public float balance { get; private set; }

    private void Start()
    {
        LoadBalance();
    }

    private void RefreshBalance()
    {
        balanceText.text = balance.ToString();
    }

    private void CoinsToLoser()
    {
        if (balance == 0)
            balance += 100;
        RefreshBalance();
    }

    public void balanceMinusBet()
    {
        balance -= betBeh.betAmount;
        RefreshBalance();
        CoinsToLoser();
        totalWinText.text = 0.ToString();
    }

    public void balanceSimpleWin()
    {
        balance += betBeh.betAmount;
        totalWinText.text = betBeh.betAmount.ToString();
        RefreshBalance();
    }

    public void balanceBJWin()
    {
        balance += betBeh.betAmount * 1.5f;
        totalWinText.text = (betBeh.betAmount * 1.5f).ToString();
        RefreshBalance();
    }

    public void StartButtonPushed()
    {
        if(betBeh.isBetReady)
        StartCoroutine(GameCor());
    }

    private IEnumerator GameCor()
    {
        scoresDealer += WhichCard(cart1, scoresDealer);
        yield return new WaitForSeconds(0.1f);
        scoresDealer += WhichCard(cart2, scoresDealer);
        yield return new WaitForSeconds(0.1f);
        scoresPlayer += WhichCard(cart3, scoresPlayer);
        yield return new WaitForSeconds(0.1f);
        scoresPlayer += WhichCard(cart4, scoresPlayer);
        yield return new WaitForSeconds(0.1f);
        Debug.Log(scoresPlayer.ToString());
        Debug.Log(scoresDealer.ToString());
        WhoWin();
        yield return new WaitForSeconds(0.1f);
        scoresPlayer = 0;
        scoresDealer = 0;
        buttonImage.sprite = buttonGrey;
        betBeh.isBetReady = false;
        betBeh.AllButtonPurple();
    }

    private int WhichCard(Image cart, int scores)
    {
        int suitIndex = Random.Range(0, 4);
        int cartIndex = Random.Range(0, 13);

        if (suitIndex == 0) { cart.sprite = spades[cartIndex]; }
        else if (suitIndex == 1) { cart.sprite = hearts[cartIndex]; }
        else if (suitIndex == 2) { cart.sprite = diamonds[cartIndex]; }
        else if (suitIndex == 3) { cart.sprite = crosses[cartIndex]; }

        // карта 2
        if (cartIndex == 0) { scores = 2; }
        // карта 3
        else if (cartIndex == 1) { scores = 3; }
        // карта 4
        else if (cartIndex == 2) { scores = 4; }
        // карта 5
        else if (cartIndex == 3) { scores = 5; }
        // карта 6
        else if (cartIndex == 4) { scores = 6; }
        // карта 7
        else if (cartIndex == 5) { scores = 7; }
        // карта 8
        else if (cartIndex == 6) { scores = 8; }
        // карта 9
        else if (cartIndex == 7) { scores = 9; }
        // карты: 10, валет, дама, король
        else if (cartIndex == 8 || cartIndex == 9 || cartIndex == 10 || cartIndex == 11) { scores = 10; }
        // карта туз
        else if (cartIndex == 12) { scores = 11; }

        return scores;
    }

    private void WhoWin()
    {
        if (scoresPlayer > 21)
        {
            Debug.Log("Игрок проиграл, у него перебор");
            balanceMinusBet();
        }
        else if (scoresDealer > 21 && scoresPlayer < 21)
        {
            Debug.Log("Дилер проиграл, у него перебор");
            balanceSimpleWin();
        }
        else if (scoresPlayer == 21 && scoresDealer != 21)
        {
            Debug.Log("Игрок победил, у него блэкджек");
            balanceBJWin();
        }
        else if (scoresDealer == 21 && scoresPlayer != 21)
        {
            Debug.Log("Дилер победил, у него блэкджек");
            balanceMinusBet();
        }
        else if (scoresDealer == 21 && scoresPlayer == 21)
        {
            Debug.Log("Ничья, у обоих блэкджек");
        }
        else if (scoresPlayer > scoresDealer)
        {
            Debug.Log("Игрок победил, у него больше очков");
            balanceSimpleWin();
        }
        else if (scoresDealer > scoresPlayer)
        {
            Debug.Log("Дилер победил, у него больше очков");
            balanceMinusBet();
        }
        else
        {
            Debug.Log("Ничья, у обоих одинаковое количество очков");
        }
    }

    private void SaveBalance()
    {
        PlayerPrefs.SetFloat("Balance", balance);
        PlayerPrefs.Save();
    }

    private void LoadBalance()
    {
        if (PlayerPrefs.HasKey("Balance"))
        {
            balance = PlayerPrefs.GetFloat("Balance");
            RefreshBalance();
        }
        else
        {
            balance = 5000;
            RefreshBalance();
        }
    }

    private void OnDestroy()
    {
        SaveBalance();
    }

    private void OnDisable()
    {
        SaveBalance();
    }
}