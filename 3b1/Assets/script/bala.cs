using UnityEngine;

public class bala : MonoBehaviour
{
    [SerializeField]private int dano = 3;
    [SerializeField]private float velocidade;
    
   // private Renderer
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidade * Time.deltaTime, 0, 0);

//if (!m_Renderer.isVisible)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.CompareTag("inimigo"))
            {   //causa dano ao inimigo
                int novaVida = collision.gameObject.GetComponent<Personagem>().Vida() - dano;
                collision.gameObject.GetComponent<Personagem>().atribuirVida(novaVida);
                //mostrar quanto de vida o inimigo agora tem
                print( "a vida restante do inimigo e " + novaVida);
            }
            //desligar bala apoos colisao
           gameObject.SetActive(false);
        }
    }
}
