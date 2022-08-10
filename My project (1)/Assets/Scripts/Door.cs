using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]

public class Door : MonoBehaviour
{
    [SerializeField] private UnityEvent<bool> IsPlayerInside;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            IsPlayerInside?.Invoke(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            IsPlayerInside?.Invoke(false);
        }
    }

}
