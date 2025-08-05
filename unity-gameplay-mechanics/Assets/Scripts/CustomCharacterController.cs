using UnityEngine;
using UnityEngine.InputSystem;

public class CustomCharacterController : MonoBehaviour
{
	[SerializeField]
	public float LinearSpeed = 5f;
	[SerializeField]
	public float AngularSpeed = 5f;
	[SerializeField]
	private Rigidbody _rigidBody;

	private InputAction _moveAction;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		_moveAction = InputSystem.actions.FindAction("Move");
	}

	// Update is called once per frame
	void Update()
	{
		Vector2 moveValue = _moveAction.ReadValue<Vector2>();
		
		_rigidBody.angularVelocity = Vector3.up * moveValue.x * AngularSpeed;
		_rigidBody.linearVelocity = _rigidBody.transform.forward * moveValue.y * LinearSpeed;

			
	}
}