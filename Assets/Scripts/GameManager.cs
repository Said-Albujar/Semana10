using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System;

public class GameManager : MonoBehaviour, ISubject
{
    public static GameManager instance;

    private int score = 0;
    public TextMeshProUGUI puntajes;
    private List<Observer> observers;

    private int puntos;

    public int puntaje { get { return puntos; } }


    void Awake()
    {
        observers = new List<Observer>();
        instance = this;
    }

    void Start()
    {
        PuntosUi();
    }
    public static GameManager Instance()
    {
        return instance;
    }
    public void Update()
    {

        notify();
    }

    public void Boton1()
    {
        score = 1;
    }
    public void Boton2()
    {
        score = 2;
    }
    public void Boton3()
    {
        score = 3;
    }

    public void attach(Observer observer)
    {
        observers.Add(observer);
    }

    public void Aumentar(int value)
    {
        score += value;
        PuntosUi();
    }

    public void detach(Observer observer)
    {
        observers.Remove(observer);
    }

    private void PuntosUi()
    {
        puntajes.text = "Puntaje: " + score.ToString();
    }
    public void notify()
    {
        foreach (Observer observer in observers)
        {
            observer.execute(this);
        }
    }
}
