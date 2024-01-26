using System.Collections.Generic;
using UnityEngine;

public class CoinsPool : MonoBehaviour
{
    public static CoinsPool instance;

    [SerializeField] int coinsAmountInPool;
    public List<GameObject> coinsInPool;


    [SerializeField] GameObject coinPrefab;
    public GameObject spawnPointGameObject;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        { Destroy(instance); }
    }


    private void Start()
    {
        coinsAmountInPool = 30;
        coinsInPool = new List<GameObject>();
        LoadCoinsOnStart();
    }
    private void LoadCoinsOnStart()
    {
        GameObject tempCoin;
        for (int i = 0; i < coinsAmountInPool; i++)
        {
            tempCoin = Instantiate(coinPrefab, spawnPointGameObject.transform.position, spawnPointGameObject.transform.rotation);
            tempCoin.SetActive(false);
            coinsInPool.Add(tempCoin);
        }
    }

    public GameObject GetCoinFromPool()
    {
        for (int i = 0; i < coinsAmountInPool; i++)
        {
            if (!coinsInPool[i].activeInHierarchy)
            {
                return coinsInPool[i];
            }
        }

        return null;
    }
}
