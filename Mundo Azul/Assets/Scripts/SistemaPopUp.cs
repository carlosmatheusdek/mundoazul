using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaPopUp : MonoBehaviour
{
    public GameObject popUpBox;
    public Sprite popUpSprite;
    public Animator animator;
    
    public void PopUp()
    {
        popUpBox.SetActive(true);
        animator.SetTrigger("pop");
    }
}