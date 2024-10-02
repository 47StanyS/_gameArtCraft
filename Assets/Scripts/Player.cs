 using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _sprint;
    [SerializeField] private float _speedCtrl;
    [SerializeField] private float _jumpForse;
    private float _healthMax = 100f;
    public float _health;
    private float _startSpeed;
    [SerializeField] SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rb2D;

    private bool _isGrounded;

    private Vector3 _position;


    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rb2D = GetComponent<Rigidbody2D>();
        _startSpeed = _speed;
        _healthMax = _health;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && _isGrounded == true)
        {
            _rb2D.AddForce(transform.up * _jumpForse, ForceMode2D.Impulse);
        }
    }
    private void FixedUpdate()
    {
        if (_health <= 0) 
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _isGrounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _isGrounded = false;
    } 
}
