using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawnerButton : MonoBehaviour
{
    [SerializeField] private PlayerCoins playerCoins;
    [SerializeField] private ChestCoins chestCoins;

    //public method to remove coin from palyer and add it to chest
    public void RemoveAddCoinOnButtonClick()
    {
        playerCoins.RemoveCoinFromPlayer();
        chestCoins.AddCoinToChest();
    }
}
