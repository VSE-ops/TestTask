using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChestCoins : MonoBehaviour
{
    //coin amount and text field objects 
    [SerializeField] private int chestCoinsAmount = 0;
    [SerializeField] private TMP_Text chestCoinsTextObject;


    private void Start()
    {
        chestCoinsTextObject.text = chestCoinsAmount.ToString();
    }

    //count coins
    public void AddCoinToChest()
    {
        chestCoinsAmount++;
        chestCoinsTextObject.text = chestCoinsAmount.ToString();
    }
}
