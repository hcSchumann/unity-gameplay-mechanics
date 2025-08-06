using UnityEngine;
using UnityEngine.InputSystem;

public class LookAction : CharacterMovementAction
{
	public float AngularSpeed = 5f;
	public LookAction(InputAction targetAction, Rigidbody targetRigidBody) : base(targetAction, targetRigidBody) { }

	protected override void PerformAction(InputAction.CallbackContext context)
	{
		Vector2 lookValue = context.ReadValue<Vector2>();

		rigidBody.angularVelocity = AngularSpeed * lookValue.x * Vector3.up;
	}
}
