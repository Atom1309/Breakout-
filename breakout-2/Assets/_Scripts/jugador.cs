using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public int limiteX = 26;
    [SerializeField] public float VelocidadPaddle = 95f; 
   

    Vector3 mousePos2D;
    Vector3 mousePos3D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
       

    // Update is called once per frame
    void Update()
    {
        //mousePos2D = Input.mousePosition;
        //mousePos2D.z = -Camera.main.transform.position.z;
        //mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);


        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.down * VelocidadPaddle * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.up * VelocidadPaddle * Time.deltaTime);
        }

        Vector3 pos = transform.position;
        //pos.x = mousePos3D.x;
        
        pos.x = Mathf.Clamp(pos.x, -limiteX, limiteX);


        transform.position = pos;

    }



}  

        
        

