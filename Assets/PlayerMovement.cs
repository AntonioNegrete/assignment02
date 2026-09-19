using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Public means it can be midified in Unity.Private means its hidden 
    public float speed = 5.0f;
    private Rigidbody rb;


    // GetComponent means Unity searches your Player object and grabs its Rigidbody component. Future rb. means Rigidbody. 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //float resets after player lets go of pressed key and constantly operate in the background. 

        float moveX = 0f;
        float moveZ = 0f;

       // if = (question you're asking)
        
        if (Keyboard.current != null)
        {
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) moveX = 1f;
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moveX = -1f;
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) moveZ = 1f;
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) moveZ = -1f;
        }
        rb.linearVelocity = new Vector3(moveX * speed, rb.linearVelocity.y, moveZ * speed);
    }
}
