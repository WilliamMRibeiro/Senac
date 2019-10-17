using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn:MonoBehaviour

    
{
    private float timeLimit = 3f;
    private float timer = 0;
    public Rigidbody respawn;

    //referencia explicita ao componente Transform da "saída"

    public Transform saida;
    
    void Update()
    {
        timer += Time.deltaTime; //atribuir o valor de "timer" com o tempo de atualização dos frames

        if (timer >= timeLimit)
        {
            timer = 0;
            Shoot();            
        }
    }

      //referencia explicita ao componente Transform da "saída"

    public Transform spawn;

   
    void Shoot()
    {
        Rigidbody instanciaProjetil;

        instanciaProjetil = Instantiate(respawn, saida.position, saida.rotation) as Rigidbody;
        

    }
}
