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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrive(InputValue value)
	{
        var val = value.Get<Vector2>();
        if (val.x == 0 && val.y == 0)
        {
            return;
        }

        var moveVector = new Vector3(val.x, 0, val.y);

        var vel = _rb.velocity;
        vel += moveVector * _acceleration;
        vel.x = Mathf.Clamp(vel.x, -_maxSpeed, _maxSpeed);
        vel.y = Mathf.Clamp(vel.y, -_maxSpeed, _maxSpeed);

        var localDir = 

        _rb.velocity = vel;

        var rot = Quaternion.LookRotation(moveVector);
        if (val.x != 0 && val.y != 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, rot, 0.05f);
        }
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
            _turretPivot.transform.rotation = Quaternion.Lerp(_turretPivot.transform.rotation, lookrot, 0.1f);
        }
    }

    public void OnShoot(InputValue value)
	{

	}
}
