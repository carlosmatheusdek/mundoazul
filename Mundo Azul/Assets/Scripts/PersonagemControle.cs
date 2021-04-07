using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonagemControle : MonoBehaviour
{
    [SerializeField]
    int velocidade = 1;

    [SerializeField]
    Button Cima = null;
    [SerializeField]
    Button Baixo = null;

    float x1 = -10.8f;
    float x2 = -10.8f*2;
    float x3 = -10.8f*3;
    float x4 = -10.8f*4;
    float x5 = -10.8f*5;
    private Animator anim;

    int cena = 0;

    Rigidbody2D rb;
    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Diving()
    {
        anim.SetBool("isDiving", true);
        rb.velocity = new Vector2(0f, -1.8f*velocidade);
        
    }

    public void Floating()
    {
        anim.SetBool("isFloating", true);
        rb.velocity = new Vector2(0f, 1.8f * velocidade);

    }
    public void EnableMoveButtons()
    {
        Cima.interactable = true;
        Baixo.interactable = true;
    }

    public void StopDiving()
    {
        anim.SetBool("isDiving", false);
        rb.velocity = new Vector2(0f, 0f);
        EnableMoveButtons();
    }

    public void StopFloating()
    {
        anim.SetBool("isFloating", false);
        rb.velocity = new Vector2(0f, 0f);
        EnableMoveButtons();
    }

    private void Update()
    {
        if (anim.GetBool("isDiving") == true)
        {
            if (rb.position.y <= x1 && cena == 0)
            {
                cena = 1;
                StopDiving();
            }
            else if (rb.position.y <= x2 && cena == 1)
            {
                cena = 2;
                StopDiving();
            }
            else if (rb.position.y <= x3 && cena == 2)
            {
                cena = 3;
                StopDiving();
            }
            else if (rb.position.y <= x4 && cena == 3)
            {
                cena = 4;
                StopDiving();
            }
            else if (rb.position.y <= x5 && cena == 4)
            {
                cena = 5;
                StopDiving();
                Baixo.interactable = false;
            }
            else if (cena == 5)
            {
                StopDiving();
                Baixo.interactable = false;
            }
        }

        if (anim.GetBool("isFloating") == true)
        {
            if (cena == 0)
            {
                StopFloating();
                Cima.interactable = false;
            }
            else if (rb.position.y >= -0.57f && cena == 1)
            {
                cena = 0;
                StopFloating();
                Cima.interactable = false;
            }
            else if (rb.position.y >= x1 && cena == 2)
            {
                cena = 1;
                StopFloating();
            }
            else if (rb.position.y >= x2 && cena == 3)
            {
                cena = 2;
                StopFloating();
            }
            else if (rb.position.y >= x3 && cena == 4)
            {
                cena = 3;
                StopFloating();
            }
            else if (rb.position.y >= x4 && cena == 5)
            {
                cena = 4;
                StopFloating();
            }
        }
    }
}
