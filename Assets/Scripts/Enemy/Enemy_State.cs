using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_State : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player_State player_State = collision.GetComponent<Player_State>();
            player_State.Player_TakeDamage(1f);
            Destroy(gameObject);
        }
    }
}
