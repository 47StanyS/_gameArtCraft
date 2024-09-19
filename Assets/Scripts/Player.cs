 using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _sprint;
    [SerializeField] private float _speedCtrl;
    private float _healthMax = 100f;
    public float _health;
    private float _startSpeed;
    [SerializeField] SpriteRenderer _spriteRenderer;

    private Vector3 _position;
    //[SerializeField] private Vector3 _dash;

    private void Start()
    {
        _startSpeed = _speed;
        _healthMax = _health;
    }
   // private void Update()
   // {
   //
   // }
    private void FixedUpdate()
    {
        if (_health < 0) 
        {
            Destroy(gameObject);
            Debug.Log("Game Over, Try again");
            SceneManager.LoadScene(0);
        }
        _health = Mathf.Clamp(_health,0,_healthMax);

        _position = transform.position;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _speed = _sprint;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            _speed = _speedCtrl;
        }
        else
        {
            _speed = _startSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            _position.x += _speed;

            _spriteRenderer.flipX = true;
        }
       if (Input.GetKey(KeyCode.A))
       {
           _position.x -= _speed;

           _spriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.J))
        {
            _position = new Vector3 (3,-4);
        }


        transform.position = _position;
    }


}
