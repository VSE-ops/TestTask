using UnityEngine;

public class CoinSetInactive : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
    }
}
