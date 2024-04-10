using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButBeh : MonoBehaviour
{
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

    public int scoresPlayer { get; private set; }
    public int scoresDealer { get; private set; }

    public void StartButtonPushed()
    {
        wichCard(cart1, scoresDealer);
        wichCard(cart2, scoresDealer);
        wichCard(cart3, scoresPlayer);
        wichCard(cart4, scoresPlayer);
    }

    private void wichCard(Image cart, int scores)
    {
        int suitIndex = Random.Range(0, 4);
        int cartIndex = Random.Range(0, 13);

        if (suitIndex == 0) { cart.sprite = spades[cartIndex]; }
        else if (suitIndex == 1) { cart.sprite = hearts[cartIndex]; }
        else if (suitIndex == 2) { cart.sprite = diamonds[cartIndex]; }
        else if (suitIndex == 3) { cart.sprite = crosses[cartIndex]; }

        if (cartIndex == 0) { scores += 2; }
        if (cartIndex == 1) { scores += 3; }
        if (cartIndex == 2) { scores += 4; }
        if (cartIndex == 3) { scores += 5; }
        if (cartIndex == 4) { scores += 6; }
        if (cartIndex == 5) { scores += 7; }
        if (cartIndex == 6) { scores += 8; }
        if (cartIndex == 7) { scores += 9; }
        if (cartIndex == 8) { scores += 10; }
        if (cartIndex == 9) { scores += 10; }
        if (cartIndex == 10) { scores += 10; }
        if (cartIndex == 11) { scores += 10; }
        if (cartIndex == 12) { scores += 11; }
    }
}
