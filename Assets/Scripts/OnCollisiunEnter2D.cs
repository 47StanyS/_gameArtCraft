using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollisiunEnter2D : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        SceneManager.LoadScene(0);
    }
}
