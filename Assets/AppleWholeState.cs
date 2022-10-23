using UnityEngine;

public class AppleWholeState : AppleBaseState
{
    float rottenCountdown = 10.0f;
    public override void EnterState(AppleStateManager apple)
    {
        //Debug.Log("Hello from the whole state");
        apple.GetComponent<Rigidbody>().useGravity = true;
    }
    public override void UpdateState(AppleStateManager apple)
    {
        if (rottenCountdown >= 0f)
        {
            rottenCountdown -= Time.deltaTime;
        }
    }
    public override void OnCollisionState(AppleStateManager apple, Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Player"))
        {
            //i need to create player gameobject with PlayerController class with it
            //also i need function addHealth()
            other.GetComponent<PlayerController>().addHealth();
            apple.SwitchState(apple.ChewedState);
        }
    }
}
