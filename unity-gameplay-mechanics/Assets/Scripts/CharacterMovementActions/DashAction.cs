using UnityEngine;
using UnityEngine.InputSystem;

public class DashAction : CharacterMovementAction
{
	public float DashImpulse = 500f;
	public int DashDurationMS = 500;
	public DashAction(InputAction targetAaction, Rigidbody targetRigidBody) : base(targetAaction, targetRigidBody) { }

	protected override void PerformAction(InputAction.CallbackContext context)
	{
		rigidBody.AddForce(1000f * DashImpulse * rigidBody.transform.forward);
	}
}
