using UnityEngine;
using UnityEngine.InputSystem;

public class WalkAction : CharacterMovementAction
{
	public float LinearSpeed = 5f;
	public WalkAction(InputAction targetAction, Rigidbody targetRigidBody) : base(targetAction, targetRigidBody) { }
    
    protected override void PerformAction(InputAction.CallbackContext context)
    {
		Vector2 moveValue = context.ReadValue<Vector2>();
		rigidBody.linearVelocity = moveValue.x * LinearSpeed * rigidBody.transform.right;
		rigidBody.linearVelocity = moveValue.y * LinearSpeed * rigidBody.transform.forward;
	}
}
