using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Puntaje : MonoBehaviour
{
    protected int score = 0;

    void Update()
    {
       
    }

    public void execute(ISubject subject)
    {
        if (subject is GameManager)
        {
            score = ((GameManager)subject).puntaje;
        }
    }

    public abstract void CambioPuntaje(int value);
}
