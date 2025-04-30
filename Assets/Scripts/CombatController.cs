using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    private float playerHealth = 100;
    private float enemyHealth = 100;
    private bool isPlayerTurn = true;

    void Update()
    {
        if (isPlayerTurn)
        {
            if (Input.GetMouseButtonDown(0)) // Click izquierdo
            {
                float damage = 15f;
                enemyHealth -= damage;
                Debug.Log($"Player attacks! Enemy HP: {enemyHealth}");
                isPlayerTurn = false;
            }
            else if (Input.GetMouseButtonDown(1)) // Click derecho
            {
                float heal = 10f;
                playerHealth += heal;
                if (playerHealth > 100) playerHealth = 100;
                Debug.Log($"Player heals! HP: {playerHealth}");
                isPlayerTurn = false;
            }
        }
        else
        {
            EnemyTurn();
        }

        if (playerHealth <= 0)
        {
            Debug.Log("Player defeated!");
            Destroy(this); // End combat
        }
        else if (enemyHealth <= 0)
        {
            Debug.Log("Enemy defeated!");
            Destroy(this); // End combat
        }
    }

    void EnemyTurn()
    {
        float rand = Random.value;
        if (rand < 0.5f)
        {
            float damage = 10f;
            playerHealth -= damage;
            Debug.Log($"Enemy attacks! Player HP: {playerHealth}");
        }
        else
        {
            float heal = 5f;
            enemyHealth += heal;
            if (enemyHealth > 100) enemyHealth = 100;
            Debug.Log($"Enemy heals! Enemy HP: {enemyHealth}");
        }

        isPlayerTurn = true;
    }
}
