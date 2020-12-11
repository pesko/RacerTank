using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
    [SerializeField]
    private float _maxSpeed;
    [SerializeField]
    private float _acceleration;
    [SerializeField]
    private Rigidbody _rb;
    [SerializeField]
    private Transform _turretPivot;
    [SerializeField]
    private Quaternion _turretRot;

    [SerializeField]
    private float _distanceToGround;

    private PlayerInput _input;


    private void KeepTurretRotation()
	{
        _turretPivot.rotation = _turretRot;
	}

    private void FaceVelocity()
	{
        var velIgnoreY = _rb.velocity;
        velIgnoreY.y = 0;
        var rot = Quaternion.LookRotation(velIgnoreY.normalized);
        var step = 0.1f * (_rb.velocity.magnitude / _maxSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, rot, step);
	}

    private bool IsGrounded()
	{
        Vector3 down = transform.TransformDirection(Vector3.down);

        if (Physics.Raycast(transform.position, down, 0.3f))
		{
            return true;
		}
        return false;
	}

    private void KeepGrounded()
	{
        Vector3 down = transform.TransformDirection(Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, down, out hit, 5f))
        {
            var pos = transform.position;
            pos.y = hit.point.y;
            transform.position = pos;
        }
    }

    public void OnDrive(InputAction.CallbackContext callback)
    {
        var val = callback.ReadValue<Vector2>();

        if (val.x == 0 && val.y == 0)
        {
            var deceleration = 0.5f * _rb.velocity;
            _rb.velocity = deceleration;
            return;
        }

        var moveVector = new Vector3(val.x, 0, val.y);

        var vel = _rb.velocity;
        vel += moveVector * _acceleration;
        vel.x = Mathf.Clamp(vel.x, -_maxSpeed, _maxSpeed);
        vel.y = Mathf.Clamp(vel.y, -_maxSpeed, _maxSpeed);

        _rb.velocity = vel;

        print(vel);
    }

    public void OnTurret(InputValue value)
	{
        var val = value.Get<Vector2>();
        if (val.x == 0 && val.y == 0)
        { 
            return; 
        }

        var joystickRot = new Vector3(val.x, 0, val.y);

        var lookrot = Quaternion.LookRotation(joystickRot);
        if (val.x != 0 && val.y != 0)
        {
            _turretPivot.rotation = Quaternion.Lerp(_turretPivot.transform.rotation, lookrot, 0.1f);
            _turretRot = _turretPivot.rotation;
        }
    }

    public void OnShoot(InputValue value)
	{

	}

    void Start()
    {
        _turretRot = _turretPivot.transform.rotation;

        _input = InputMaster.Instance.PlayerInput;

		_input.Tank.Drive.performed += OnDrive;
    }

	// Update is called once per frame
	void Update()
    {
        FaceVelocity();
        KeepTurretRotation();
        //KeepGrounded();
    }

	private void OnDestroy()
	{
		_input.Tank.Drive.performed -= OnDrive;
    }
}
