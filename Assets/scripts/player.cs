using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float speed = 5f;
    private Rigidbody2D rb2D;
    private float moveInput;

    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb2D.linearVelocity = new Vector2(moveInput * speed, rb2D.linearVelocity.y);
    }
}
