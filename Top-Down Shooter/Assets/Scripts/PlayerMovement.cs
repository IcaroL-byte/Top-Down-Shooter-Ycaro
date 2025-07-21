using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private int speedPlayer;
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private Transform transform;
    private Animator animator;  
    
    [Header("Limits")]
    [SerializeField] private float limitX1;
    [SerializeField] private float limitX2;
    [SerializeField] private float limitY1;
    [SerializeField] private float limitY2;
    
    [Header("Life")]
    [SerializeField]
    private int vida;
    [SerializeField]
    private int energia;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
        transform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       Limits();
    }

    void FixedUpdate()
    {
        Move();
    }

    public int getVida()
    {
        return this.vida;
    }

    public void SetVidas(int vida)
    {
        this.vida = vida;
    }

    public int getEnergia()
    {
        return this.energia;
    }

    public void SetEnergia(int energia)
    {
        this.energia = energia;
    }
    
    void Move()
    {
        animator.SetBool("onMove", false);
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        moveDirection = new Vector2(horizontal, vertical);
        
        Vector3 movePosition = (speedPlayer * Time.fixedDeltaTime * moveDirection.normalized) + rb.position;
        rb.MovePosition(movePosition);

        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            animator.SetBool("onMove", true);
        }
    
    }


    void Limits()
    {
        

        if (transform.position.x < limitX2)
        {
            transform.position = new Vector2(limitX2, transform.position.y);
        }

        if (transform.position.y > limitY1)
        {
            transform.position = new Vector2(transform.position.x, limitY1);
        }

        if (transform.position.y < limitY2)
        {
            transform.position = new Vector2(transform.position.x, limitY2);
        }
    }
}
