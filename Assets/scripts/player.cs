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
        // movimiento horizontal
        moveInput = Input.GetAxisRaw("Horizontal");
        rb2D.linearVelocity = new Vector2(moveInput * speed, rb2D.linearVelocity.y);

        if(moveInput != 0)
        {
            // Cambiar la dirección del sprite según el movimiento
            transform.localScale = new Vector3(Mathf.Sign(moveInput), 1, 1);
        }
    }
}
