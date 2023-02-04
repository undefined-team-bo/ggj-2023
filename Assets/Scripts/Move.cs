using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 70f;
    public float dashImpulse = 20f;

    private Rigidbody _rigidBody;

    private float _dashCD = 5f;
    private float _currentDashCD = 0f;
    private bool _shouldDash;
    [HideInInspector]
    public bool isDashing = false;
    private float _minDashVel = 100f;


    private float _currentStunCD = 0f;
    private float _stunCD = 2f;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Stun
        if (_currentStunCD > 0)
        {
            _currentStunCD -= Time.deltaTime;
            return;
        }

        // Dash
        if (_currentDashCD > 0f)
        {
            _currentDashCD -= Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            _shouldDash = true;
            _currentDashCD = _dashCD;
        }
    }

    void FixedUpdate()
    {
        if (_currentStunCD > 0)
        {
            return;
        }

        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        float inputVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = transform.forward * inputVertical;
        _rigidBody.MovePosition(_rigidBody.position + movement * Time.fixedDeltaTime * speed);

        Quaternion rotation = Quaternion.Euler(Vector3.up * inputHorizontal * Time.fixedDeltaTime * rotationSpeed);
        _rigidBody.MoveRotation(_rigidBody.rotation * rotation);

        // Dash RB

        float currVel = _rigidBody.velocity.sqrMagnitude;
        if (isDashing && currVel < _minDashVel)
        {
            isDashing = false;
        }

        if (_shouldDash)
        {
            _shouldDash = false;
            isDashing = true;
            _rigidBody.AddForce(transform.forward * dashImpulse, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Move moveController = collision.gameObject.GetComponent<Move>();
        if (collision.gameObject.CompareTag("Player") && moveController.isDashing)
        {
            InitStun();
        }
    }

    private void InitStun()
    {
        _currentStunCD = _stunCD;
    }
}