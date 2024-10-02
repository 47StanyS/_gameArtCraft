using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] GameObject _coins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
