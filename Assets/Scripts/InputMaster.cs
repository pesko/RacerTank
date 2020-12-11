using UnityEngine;

public class InputMaster : MonoBehaviour
{
	private PlayerInput _playerInput;

    public PlayerInput PlayerInput 
	{ 
		get
		{
			if (_playerInput == null)
			{
				_playerInput = new PlayerInput();
				_playerInput.Enable();
			}
			return _playerInput;
		}
	}

	public static InputMaster Instance { get; private set; }

	protected void Awake()
	{
		if (Instance != null)
		{
			Destroy(gameObject);
			return;
		}

		Instance = this;
	}
}
