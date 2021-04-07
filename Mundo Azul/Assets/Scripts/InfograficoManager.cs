using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfograficoManager : MonoBehaviour
{
    public bool popUpON = false;
    public Vector3 popUpPosition1 = new Vector3(-547, 774, 0);
    public Vector3 popUpPosition2 = new Vector3(498, 774, 0);

    public void popUpOFF()
    {
        popUpON = false;
    }
}
