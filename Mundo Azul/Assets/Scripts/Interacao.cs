using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interacao : MonoBehaviour
{
    [SerializeField]
    public GameObject popUpBox;
    public Sprite newInfo;
    public Sprite sprHover;
    public InfograficoManager IM;
    
    private Sprite iddle = null;

    private void Start()
    {
        iddle = this.GetComponent<SpriteRenderer>().sprite;
    }

    private void Update()
    {
        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D coll = this.GetComponent<Collider2D>();
        SpriteRenderer sprite = this.GetComponent<SpriteRenderer>();

        if (coll.OverlapPoint(wp))
        {
            if (!IM.popUpON) sprite.sprite = sprHover;

            if (Input.GetMouseButtonDown(0) && !IM.popUpON)
            {
                Image image = popUpBox.GetComponent<Image>();
                Animator animator = popUpBox.GetComponent<Animator>();
                image.sprite = newInfo;
                animator.SetTrigger("pop");
                IM.popUpON = true;
            }
        } else
        {
            sprite.sprite = iddle;
        }
    }
}