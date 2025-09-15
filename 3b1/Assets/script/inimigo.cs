using UnityEngine;

public class inimigo : Personagem
{
    [SerializeField]private int dano = 3;
    
  
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vida() <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //CAUSAR DANO AO INIMIGO
            if (collision.gameObject.CompareTag("Player"))
            {
                //causa dano ao player
              int novavida = collision.gameObject.GetComponent<Personagem>().Vida() - dano;
              collision.gameObject.GetComponent<Personagem>().atribuirVida(novavida);
              print("a vida restante do player agora e " + novavida);

              //collision.gameObject.GetComponent<Personagem>().receberDano(dano());
              
              //desativar quando a bate no player
              gameObject.SetActive(false);
            }
    }
}
