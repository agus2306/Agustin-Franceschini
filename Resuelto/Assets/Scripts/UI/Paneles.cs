using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paneles : MonoBehaviour
{
    public GameObject Panel_Izq;
    public GameObject Panel_Der;
    
    // Start is called before the first frame update
    public void Start()
    {
        Iniciar_Animacion();
    }

    public void Iniciar_Animacion()
    {
        if (GetComponent<GameManager>().isGameOn == true)
        {
            Abrir_Paneles();
        }
    }

    public void Abrir_Paneles()
    {
        if (Panel_Izq != null)
        {
            Animator animator = Panel_Izq.GetComponent<Animator>();

            if (animator != null)
            {
                bool GameOn = animator.GetBool("Juego_Iniciado");
            }                 
        }
        if (Panel_Der != null)
        {
            Animator animator = Panel_Der.GetComponent<Animator>();

            if (animator != null)
            {
                bool GameOn = animator.GetBool("Juego_Iniciado");
            }
        }
    }
}
