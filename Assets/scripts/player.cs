using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float speed = 5f;
    private Rigidbody2D rb2D;
    private float moveInput;
    public float jumpForce = 4f;
    private bool isGrounded;
    public Transform groundCheck;
    public float groundRadius = 0.1f;
    public LayerMask groundLayer;

    
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

            // salto
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, jumpForce);
        }
    }

    private void FixedUpdate()
    {
        // Comprobar si el jugador está en el suelo
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);

/*
        // limitar el movimiento horizontal del jugador dentro de los límites de la pantalla
        rb2D.linearVelocity = new Vector2(moveInput * speed, rb2D.linearVelocity.y);

        float clampedX = Mathf.Clamp(transform.position.x, -4f, 8f);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);*/
        
    }

    // Detectar colisiones con monedas (desaparecen al tocarlas)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }
        
    }


}
