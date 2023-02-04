using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 4f;
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

        Vector3 movement = new Vector3(inputHorizontal, 0.0f, inputVertical);

        _rigidBody.MovePosition(transform.position + movement * Time.deltaTime * speed);

        // Dash RB
        if (_shouldDash)
        {
            _shouldDash = false;
            _rigidBody.AddForce(transform.forward * dashImpulse, ForceMode.Impulse);
        }
    }
}