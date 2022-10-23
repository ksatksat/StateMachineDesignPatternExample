using UnityEngine;

public class AppleRottenState : AppleBaseState
{
    public override void EnterState(AppleStateManager apple)
    {

    }
    public override void UpdateState(AppleStateManager apple)
    {

    }
    public override void OnCollisionState(AppleStateManager apple, Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Player"))
        {
            //i need to create player gameobject with PlayerController class with it
            //also i need function addHealth()
            other.GetComponent<PlayerController>().detractHealth();
            apple.SwitchState(apple.ChewedState);
        }
    }
}
