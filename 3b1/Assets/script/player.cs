using UnityEngine;

public class Player : Personagem
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += new Vector3(0, Velocidade()*Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= new Vector3(0, Velocidade()*Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(Velocidade()*Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position -= new Vector3(Velocidade()*Time.deltaTime, 0, 0);
        }
    }
}
