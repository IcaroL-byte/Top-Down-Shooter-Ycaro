using UnityEngine;

public class PontoDeTiro : MonoBehaviour
{
    private SpriteRenderer srGun;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        srGun = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PonteiroCam();
    }

    void PonteiroCam()
    {
        Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = (Vector3)(mousePos - new Vector2(transform.position.x, transform.position.y)) ;

        if (transform.rotation.z > 0)
        {
            srGun.flipX = false;
        }
        
        if (transform.rotation.z <= 0)
        {
            srGun.flipX = true;
        }
        
    }

}
