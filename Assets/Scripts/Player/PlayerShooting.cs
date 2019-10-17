using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Rigidbody projetil;

    //referencia explicita ao componente Transform da "saída"

    public Transform saida;
    public float shotSpeed = 50f;

    private void Update()
    {
        //verifica se a tecla espaço foi pressionada
        if (Input.GetButtonDown("Fire1"))
        {
            //chamar a função "Shoot"
            Shoot();
        }
    }

    void Shoot()
    {
        Rigidbody instanciaProjetil;

        instanciaProjetil = Instantiate(projetil, saida.position, saida.rotation) as Rigidbody;
        instanciaProjetil.velocity = shotSpeed * saida.forward;

    }
}
