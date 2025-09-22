using UnityEngine;

public class inimigo : Personagem
{
    [SerializeField]private int dano = 3;
    
    [SerializeField]private Transform  posicaoDoPlayer;

    private void atribuirDano(int dano)
    {
        this.dano = dano;
    }

    private int Dano(int dano)
    {
        return dano;
    }
    
  
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (posicaoDoPlayer == null)
        {
            posicaoDoPlayer = transform.Find("Player");
        }
    }

    // Update is called once per frame    
    void Update()
    { 
        //if (posicaoDoPlayer.position.x - transform.position.x > 0)
     //   {
     //  SpriteRenderer = true;
     //   }
     //   else(posicaoDoPlayer.position.x - transform.position.x < 0);
     //   {
     //      SpriteRenderer.flipX = false;
     //  }
        
       if (posicaoDoPlayer != null)
       {
           Debug.Log("posicao do player " + posicaoDoPlayer.position);
           
            transform.position = Vector3.MoveTowards(transform.position,target:posicaoDoPlayer.transform.position,maxDistanceDelta:Velocidade() * Time.deltaTime);
        }
        
        
        
        
        
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
              print("A vida restante do player agora e " + novavida);

              //collision.gameObject.GetComponent<Personagem>().receberDano(dano());
              
              //desativar quando a bate no player
              gameObject.SetActive(false);
            }
    }
}
