using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] GameObject _coins;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
