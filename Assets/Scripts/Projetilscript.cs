using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projetilscript : MonoBehaviour
{
    // Start is called before the first frame update


    private float timeLimit = 3f;
    private float timer = 0;


    private void Update()
    {
        //criar uma variavel contadora
        timer += Time.deltaTime; //atribuir o valor de "timer" com o tempo de atualização dos frames

        if (timer >= timeLimit)
        {
            timer = 0;
            Destroy(gameObject);
        }

        

        //comparar o valor do contador com o tempo limite
        //se for igual ou maior...
        //resetar o contador
        //destrior o Game Object
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Nome do Objeto: " + other.gameObject.name);

        if(other.gameObject.tag == "Enemy")
        {

            other.gameObject.SetActive(false);

            //contar pontos

            ScoreManager score;

            score = GameObject.Find("Score").GetComponent<ScoreManager>();
            score.Points = 10;

        }
        


    }

}

