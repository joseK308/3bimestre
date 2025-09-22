using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Slider sliderVidasRestantes;
    
    public Personagem personagem;
    [SerializeField]
    private int vidasRestantes = 0;
    
  
    void Start()
    {
        if (personagem != null)
        {
            if (sliderVidasRestantes != null)
            {
                sliderVidasRestantes.minValue = 0;
                sliderVidasRestantes.maxValue = personagem.Vida();
            }
        }
    }

    void Update()
    {
        if (sliderVidasRestantes != null)
        {
            vidasRestantes = personagem.Vida();
            sliderVidasRestantes.value = vidasRestantes;
        }
    }
}