using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStarter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() && other.GetComponent<CombatController>() == null)
        {
            other.gameObject.AddComponent<CombatController>();
            Debug.Log("¡Combate iniciado!");
        }
    }
}
