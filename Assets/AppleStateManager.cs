using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleStateManager : MonoBehaviour
{
    AppleBaseState currentState;
    public AppleGrowingState GrowingState = new AppleGrowingState();
    public AppleChewedState ChewedState = new AppleChewedState();
    public AppleRottenState RottenState = new AppleRottenState();
    public AppleWholeState WholeState = new AppleWholeState();

    void Start()
    {
        //starting state for the state machine
        currentState = GrowingState;
        currentState.EnterState(this);
    }
    void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionState(this, collision);
    }
    void Update()
    {
        currentState.UpdateState(this);
    }
    public void SwitchState(AppleBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
