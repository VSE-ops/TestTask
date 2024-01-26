using TMPro;
using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    [SerializeField] private int playerCoinsAmountDefault = 30;
    private int playerCurrentCoinsAmount;
    [SerializeField] private TMP_Text playerCoinsTextObject;

    private void Start()
    {
        playerCoinsTextObject.text = playerCoinsAmountDefault.ToString();
        playerCurrentCoinsAmount = playerCoinsAmountDefault;
    }

    public void RemoveCoinFromPlayer()
    {
        if (playerCurrentCoinsAmount == 0)
        {
            playerCurrentCoinsAmount = playerCoinsAmountDefault;
            RemoveAndActivateCoins();
        }
        else
        {
            RemoveAndActivateCoins();
        }
    }

    private void RemoveAndActivateCoins()
    {
        playerCurrentCoinsAmount--;
        playerCoinsTextObject.text = playerCurrentCoinsAmount.ToString();
        GameObject coin = CoinsPool.instance.GetCoinFromPool();
        GameObject coinSpawnPoint = CoinsPool.instance.spawnPointGameObject;
        if (coin != null)
        {
            coin.transform.position = coinSpawnPoint.transform.position;
            coin.transform.rotation = coinSpawnPoint.transform.rotation;
            coin.SetActive(true);
        }
    }
}
