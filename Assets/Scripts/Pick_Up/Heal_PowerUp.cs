using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal_PowerUp : MonoBehaviour
{
    [SerializeField] private int heal_Amount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player_State player = collision.GetComponent<Player_State>();
            player.Add_Health(heal_Amount);
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
