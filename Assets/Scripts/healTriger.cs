using UnityEngine;

public class healTriger : MonoBehaviour
{
    private Player _player;
    private void FixedUpdate()
    {
        if (_player)
        {
            _player._health++;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Heal");
            _player = collision.GetComponent<Player>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player = null;
            collision.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
