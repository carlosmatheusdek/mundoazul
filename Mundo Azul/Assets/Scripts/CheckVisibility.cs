using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVisibility : MonoBehaviour
{
    [SerializeField]
    public static int sec = 3;

    int timer = sec * 60;
    bool count = false;

    private void OnBecameVisible()
    {
        count = true;

    }

    private void OnBecameInvisible()
    {
        count = false;
        timer = sec * 60;
        this.GetComponent<Animator>().SetTrigger("invisible");
    }

    private void Update()
    {
        if (count)
        {
            timer--;
            if(timer == 0)
            {
                this.GetComponent<Animator>().SetTrigger("visible");
                count = false;
                timer = sec * 60;
            }
        }
    }

}
