using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if( Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * _speed;
            _spriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            transform .position -= transform.right * _speed;
            _spriteRenderer.flipX = false;
        }
      // if (Input.GetKey(KeyCode.W))
      // {
      //     GetComponent<Rigidbody2D>().AddForce(transform.up * 1, ForceMode2D.Impulse);
      // }
      // if (Input.GetKeyDown(KeyCode.W))
      // {
      //     GetComponent<Rigidbody2D>().gravityScale *= -1;
      // }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}
