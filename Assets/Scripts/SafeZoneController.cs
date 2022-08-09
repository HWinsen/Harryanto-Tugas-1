using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZoneController : MonoBehaviour
{
    [SerializeField] private LifeController _lifeController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Zombie"))
        {
            // Kurangin darah
            _lifeController.RemoveLife();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
    }
}
