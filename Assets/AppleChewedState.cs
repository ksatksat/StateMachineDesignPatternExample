using UnityEngine;

public class AppleChewedState : AppleBaseState
{
    float destroyCountdown = 5.0f;
    public override void EnterState(AppleStateManager apple)
    {

    }
    public override void UpdateState(AppleStateManager apple)
    {
        if (destroyCountdown > 0)
        {
            destroyCountdown -= Time.deltaTime;
        }
        else
        {
            Object.Destroy(apple.gameObject);
        }
    }
    public override void OnCollisionState(AppleStateManager apple, Collision collision)
    {

    }
}
