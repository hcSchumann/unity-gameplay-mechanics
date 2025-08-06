using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public abstract class CharacterMovementAction
{
    public bool IsPerforming;

    protected InputAction inputAction;
    protected Rigidbody rigidBody;

    private HashSet<CharacterMovementAction> _blockingActions = new();


	protected CharacterMovementAction(InputAction targetAaction, Rigidbody targetRigidBody)
    {
        inputAction = targetAaction;
		rigidBody = targetRigidBody;

        inputAction.performed += PerformAction;
	}

    public void AddBlockingMovementAction(CharacterMovementAction action)
    {
        _blockingActions.Add(action);
	}

	public void RemoveBlockingMovementAction(CharacterMovementAction action)
	{
		_blockingActions.Remove(action);
	}

	protected abstract void PerformAction(InputAction.CallbackContext context);

    private void TryPerformAction(InputAction.CallbackContext context)
    {
		foreach(var action in _blockingActions)
        {
            if (action.IsPerforming) return;
        }

		PerformAction(context);
	}
}
