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

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Dash
        if (_currentDashCD < 0.1 && Input.GetKeyDown(KeyCode.Space))
        {
            _shouldDash = true;
            _currentDashCD = _dashCD;
        }
        else if (_currentDashCD > 0f)
        {
            _currentDashCD -= Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        float inputVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = transform.forward * inputVertical;
        _rigidBody.MovePosition(_rigidBody.position + movement * Time.fixedDeltaTime * speed);

        Quaternion rotation = Quaternion.Euler(Vector3.up * inputHorizontal * Time.fixedDeltaTime * rotationSpeed);
        _rigidBody.MoveRotation(_rigidBody.rotation * rotation);

        // Dash RB
        if (_shouldDash)
        {
            _shouldDash = false;
            _rigidBody.AddForce(transform.forward * dashImpulse, ForceMode.Impulse);
        }
    }
}