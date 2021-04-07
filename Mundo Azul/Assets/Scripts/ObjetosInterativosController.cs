using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosInterativosController : MonoBehaviour
{
    [SerializeField]
    public GameObject Tubarao;

    private void Start()
    {

    }

    private void Update()
    {
        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D collTubarao = Tubarao.GetComponent<Collider2D>();
        SpriteRenderer sprTubarao = Tubarao.GetComponent<SpriteRenderer>();

        if (collTubarao.OverlapPoint(wp))
        {
            if (Input.GetMouseButtonDown(0))
            {
            }
        }
    }
}
