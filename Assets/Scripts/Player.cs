 using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _sprint;
    [SerializeField] private float _speedCtrl;
    [SerializeField] SpriteRenderer _spriteRenderer;

    private Vector3 _position;

    private void Update()
    {

    }
    private void FixedUpdate()
    {
        _position = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            _position.x += _speed;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _position.x += _sprint;
            }
            if (Input.GetKey(KeyCode.LeftControl))
            {
                _position.x +=  _speedCtrl;
            }
            _spriteRenderer.flipX = true;
        }
       if (Input.GetKey(KeyCode.A))
       {
           _position.x -= _speed;
           if (Input.GetKey(KeyCode.LeftShift))
           {
               _position.x -= _sprint;
           }
           if (Input.GetKey(KeyCode.LeftControl))
           {
               _position.x -= _speedCtrl;
           }
           _spriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.J))
        {
            _position.x += 0.8f;
            _position.y += 0.6f;
        }


        transform.position = _position;
    }

  // private void OnCollisionEnter2D(Collision2D collision)
  // {
  //     SceneManager.LoadScene(0);
  // }
}
