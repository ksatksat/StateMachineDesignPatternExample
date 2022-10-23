using UnityEngine;

public abstract class AppleBaseState
{
    public abstract void EnterState(AppleStateManager apple);
    public abstract void UpdateState(AppleStateManager apple);
    public abstract void OnCollisionState(AppleStateManager apple, Collision collision);
}
