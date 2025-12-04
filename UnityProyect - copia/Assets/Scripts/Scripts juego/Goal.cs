using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool levelCompleted = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Aster"))
        {
            levelCompleted = true;
            Debug.Log("Nivel completado! El jugador llegó a la meta.");
        }
    }
}
