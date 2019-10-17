using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour


{
    public float velocidade = 3.5f;

    private PlayerHealth m_PlayerHealth;
    private Renderer m_Renderer;


    //funcao chamada quando o script é habilitado.
    private void OnEnable()
    {
        
    }
    //função chamada após a compilação do código
    private void Awake()
    {
        //Acessar o componente "PlayerHealth" que esta neste Game Object
        m_PlayerHealth = GetComponent<PlayerHealth>();

        //Acessar o componente "Renderer" que está nesta Game Object
        m_Renderer = GetComponent<Renderer>();
    }
        // função chamada antes da execução do primeiro frame
    private void Start()
    {
        m_Renderer.material.color = Color.black;
    

   
        Debug.Log("Vida" + m_PlayerHealth.health);

        m_PlayerHealth.health = 50;

        Debug.Log("Vida" + m_PlayerHealth.health);
    }

    // função chamada a cada frame executado no jogo
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * velocidade;
        float v = Input.GetAxis("Vertical") * velocidade;
        DoMovement(h, v);

    }
    //função chamada quando o script é desabilitado
    private void OnDisable()
    {
        
    }

    
    void DoMovement(float h, float v)
    {
        transform.Translate(0, 0, v);
        transform.Rotate(0, h, 0);

    }
    


    /*void Movement()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Se movimentando pra frente");

            //Deslocar no eixo z
            //Vector3 (x,y,z)
            transform.Translate(0, 0, 0.1f * velocidade);

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Se movimentando para esquerda");

            transform.Rotate(0, 0.1f * -velocidade, 0);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Se movimentando para trás");

            transform.Translate(0, 0, 0.1f * -velocidade);

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Se movimentando para direita");

            transform.Rotate(0, 0.1f * velocidade, 0);
        }
        
        

    }*/
}
