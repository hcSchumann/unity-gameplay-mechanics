using UnityEngine;
using UnityEngine.InputSystem;

public class JumpAction : CharacterMovementAction
{
	public float JumpForce = 500f;
	public int JumpDurationMS = 500;
	public JumpAction(InputAction targetAaction, Rigidbody targetRigidBody) : base(targetAaction, targetRigidBody) { }

	protected override void PerformAction(InputAction.CallbackContext context)
	{
		rigidBody.AddForce(1000f * JumpForce * Vector3.up);
	}
}
