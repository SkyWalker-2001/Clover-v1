using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_Spawn : MonoBehaviour
{
    [SerializeField] private float Life_Spawn_Time;
    void Start()
    {
        StartCoroutine(Life_Time());
    }

    IEnumerator Life_Time()
    {
        yield return new WaitForSeconds(Life_Spawn_Time);
        Destroy(gameObject);
    }
}
