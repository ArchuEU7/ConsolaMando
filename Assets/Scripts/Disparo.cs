using UnityEngine;
using UnityEngine.InputSystem;

public class Disparo : MonoBehaviour
{
    public GameObject arrow;
    public float VelocidadHorizontal = 100;
    public float TiempoArrow;
    private Rigidbody2D rbb;
    public Transform brazo;
    //public GameObject arrowClon;

  
        public void OnShoot(InputValue value)
        
    {
        if (value.isPressed)
            Disparar();
    }
    public void Awake()
    {
        rbb = GetComponent<Rigidbody2D>();
    }




    public void Disparar()
    {

        if (rbb != null)
        {
            rbb.linearVelocity = new Vector2(VelocidadHorizontal, 0f);
        }
        GameObject arrowClon = Instantiate(arrow, brazo.position, Quaternion.identity);
        Rigidbody2D rbClon = arrowClon.GetComponent<Rigidbody2D>();
        if (rbClon != null)
        {
            rbClon.linearVelocity = new Vector2(VelocidadHorizontal, 0f);
            rbClon.gravityScale = 0f;
        }

        Destroy(arrowClon, TiempoArrow); } 
}



    
