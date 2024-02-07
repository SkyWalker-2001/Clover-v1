using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_PickUp : MonoBehaviour
{
    [SerializeField] private int coin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player_State player = collision.GetComponent<Player_State>();
            player.Add_Collectable_Coin(coin);
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
