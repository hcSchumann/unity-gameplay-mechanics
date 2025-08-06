using UnityEngine;
using UnityEngine.InputSystem;

public class CustomCharacterController : MonoBehaviour
{
	[SerializeField]
	private Rigidbody _rigidBody;

	private WalkAction _walkAction;
	private LookAction _lookAction;
	private JumpAction _jumpAction;
	private DashAction _dashAction;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		_walkAction = new WalkAction(InputSystem.actions.FindAction("Move"), _rigidBody);
		_lookAction = new LookAction(InputSystem.actions.FindAction("Look"), _rigidBody);
		_jumpAction = new JumpAction(InputSystem.actions.FindAction("Jump"), _rigidBody);
		_dashAction = new DashAction(InputSystem.actions.FindAction("Dash"), _rigidBody);

		_walkAction.AddBlockingMovementAction(_dashAction);
	}
}