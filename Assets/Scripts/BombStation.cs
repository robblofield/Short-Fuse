using UnityEngine;

public class BombStation : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.GetComponent<PlayerController>();

        if (player == null)
        {
            return;
        }

        player.RefillBombs();
    }


}
