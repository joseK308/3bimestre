using UnityEngine;

public class Personagem : MonoBehaviour


{
    [SerializeField]
    private float velocidade;
    [SerializeField]
    private int vida;
    [SerializeField]
    private int energia;

    public void atriuirVelocidade()
    {
        this.velocidade = this.velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }

    public void atribuirVida()
    {
        this.vida = this.vida;
    }

    public int Vida()
    {
        return this.vida;
    }

    public void AtribuirEnergia()
    {
        this.energia = this.energia;
    }

    public int Energia()
    {
        return this.energia;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
