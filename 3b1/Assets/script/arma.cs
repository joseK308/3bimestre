using UnityEngine;

public class arma : MonoBehaviour
{
    public Transform saidaDaMunicao;
    
    public GameObject bala;
    public float intervaloDeDisparos = 0.5f;

    private float tempoDeDisparos = 0F;
    
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if (tempoDeDisparos <= 0 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("bala disparou");
            
            GameObject b = Instantiate(bala, saidaDaMunicao.position, saidaDaMunicao.rotation); 
            
            tempoDeDisparos = intervaloDeDisparos;
        }

        if (tempoDeDisparos > 0)
        {
            tempoDeDisparos -= Time.deltaTime;
        }
    }
}
