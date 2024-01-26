using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class PlayerCoins : MonoBehaviour
{
    //coin amount and text field objects 
    [SerializeField] private int playerCoinsAmount = 30;
    [SerializeField] private TMP_Text playerCoinsTextObject;

    //point in scene where to instantiate coins
    [SerializeField] GameObject spawnPointGameObject;
    //Coin prefab with box collider
    [SerializeField] GameObject coinPrefab;

    //list of pre-instantiated coins
    private List<GameObject> coinList;
    private void Start()
    {
        playerCoinsTextObject.text = playerCoinsAmount.ToString();
        ReloadCoins();
    }

    //public method to remove coin from player, enable coin and reload amount of coins to 30 if player have 0 coins
    public void RemoveCoinFromPlayer()
    {
        if (playerCoinsAmount == 0)
        {
            playerCoinsAmount = 30;
            ReloadCoins();
            RemoveAndActivateCoins();
        }
        else
        {
            RemoveAndActivateCoins();
        }
    }

    //this method will reload the list of coins 
    private void ReloadCoins()
    {
        coinList = new List<GameObject>();
        GameObject tempCoin;
        for (int i = 0; i < playerCoinsAmount; i++)
        {
            tempCoin = Instantiate(coinPrefab, spawnPointGameObject.transform.position, spawnPointGameObject.transform.rotation);
            tempCoin.SetActive(false);
            coinList.Add(tempCoin);
        }

    }

    //count player coins 
    private void RemoveAndActivateCoins()
    {
        playerCoinsAmount--;
        playerCoinsTextObject.text = playerCoinsAmount.ToString();
        coinList[0].SetActive(true);
        coinList.Remove(coinList[0]);
    }
}
