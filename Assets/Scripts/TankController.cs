using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.VFX;

public class TankController : MonoBehaviour
{
    #region Serialized Fields

    [SerializeField]
    private float _maxSpeed;
    [SerializeField]
    private float _acceleration;
    [SerializeField]
    private Rigidbody _rb;
    [SerializeField]
    private Transform _turretPivot;
    [SerializeField]
    private Animator _barrelAnimator;
    [SerializeField]
    private AnimationClip _barrelAnimation;
    [SerializeField]
    private AudioSource _barrelAudio;
    [SerializeField]
    private AudioClip _shotFX;
    [SerializeField]
    private VisualEffect _shotVFX;

    #endregion Serialized Fields

    #region Private Fields

    private PlayerInput _input;
    private Vector3 _moveVector;
    private Quaternion _turretRot;

    #endregion Private Fields

    #region Private Methods

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

    private void Drive()
	{
        if (_moveVector.x == 0 && _moveVector.y == 0)
        {
            var deceleration = 0.5f * _rb.velocity;
            _rb.velocity = deceleration;
            return;
        }

        var vel = _rb.velocity;
        vel += _moveVector * _acceleration;
        vel.x = Mathf.Clamp(vel.x, -_maxSpeed, _maxSpeed);
        vel.y = Mathf.Clamp(vel.y, -_maxSpeed, _maxSpeed);

        _rb.velocity = vel;
    }

    private void Turret()
	{
        _turretPivot.rotation = Quaternion.Lerp(_turretPivot.transform.rotation, _turretRot, 0.25f);
    }

    private void ApplyGravity()
	{
        var vel = _rb.velocity;

        vel.y -= Physics.gravity.y;
	}

    private void OnDrive(InputAction.CallbackContext callback)
    {
        var v = callback.ReadValue<Vector2>();
        _moveVector = new Vector3(v.x, 0, v.y);
    }

    private void OnTurret(InputAction.CallbackContext callback)
    {
        var val = callback.ReadValue<Vector2>();
        var v3 = new Vector3(val.x, 0, val.y);
        _turretRot = Quaternion.LookRotation(v3);
    }

    private void OnShoot(InputAction.CallbackContext callback)
    {
        _barrelAnimator.Play(_barrelAnimation.name);
        _barrelAudio.PlayOneShot(_shotFX);
        _shotVFX.SendEvent("OnPlay");
    }

    #endregion Private Methods

    #region Unity Callbacks

    void Start()
    {
        _turretRot = _turretPivot.transform.rotation;

        _input = InputMaster.Instance.PlayerInput;

		_input.Tank.Drive.performed += OnDrive;
        _input.Tank.Turret.performed += OnTurret;
        _input.Tank.Shoot.performed += OnShoot;
    }

    // Update is called once per frame
    void Update()
    {
        FaceVelocity();
    }

	protected void FixedUpdate()
	{
        Drive();
        Turret();
        ApplyGravity();
	}

	private void OnDestroy()
	{
		_input.Tank.Drive.performed -= OnDrive;
        _input.Tank.Turret.performed -= OnTurret;
        _input.Tank.Shoot.performed -= OnShoot;
    }

	#endregion Unity Callbacks
}
