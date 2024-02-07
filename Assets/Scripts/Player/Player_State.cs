using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine.UI;

public class Player_State : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private Image fill_Image;

    private float health;
    private int coin_Prefab;
    private int coin_Amount;

    public bool canTakeDamage = true;

    void OnEnable()
    {
        health = maxHealth;
        fill_Image.fillAmount = health / maxHealth;
       // EndGame_Manager.endGame_Manager.gameOver = false;

        StartCoroutine(Damage_Protection());
    }

    private void Start()
    {
        EndGame_Manager.endGame_Manager.RegisterPlayerState(this);
        EndGame_Manager.endGame_Manager.gameOver = false;
        coin_Amount = 0;
    }

    public void Player_TakeDamage(float damage)
    {
        if (canTakeDamage == false)
            return;

        //if (shield.protection)
        //    return;

        health -= damage;
        //Instantiate(Explosion_Prefab, transform.position, transform.rotation);

    

        fill_Image.fillAmount = health / maxHealth;

        if (health <= 0)
        {

            EndGame_Manager.endGame_Manager.gameOver = true;
            EndGame_Manager.endGame_Manager.StartResolveSequence();
            //Instantiate(Explosion_Prefab, transform.position, transform.rotation);
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

    
    public void Add_Health(int healAmount)
    {
        health += healAmount;
        if (health > maxHealth)
            health = maxHealth;
        fill_Image.fillAmount = health / maxHealth;
    }

    public void Add_Collectable_Coin(int coin_am)
    {
        Debug.Log(coin_Amount);

        coin_Amount += coin_am;
        Debug.Log(coin_Amount);
    }
    IEnumerator Damage_Protection()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(1.5f);
        canTakeDamage = true;
    }
}
