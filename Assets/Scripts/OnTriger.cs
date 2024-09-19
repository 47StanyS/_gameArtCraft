using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over, Try Again");
            SceneManager.LoadScene(0);
        }

    }
}
