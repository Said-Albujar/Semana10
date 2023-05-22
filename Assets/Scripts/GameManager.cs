using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    int score = 0;
    public TextMeshProUGUI puntajeTexto;

    public void Start()
    {
        PuntajeTexto();
    }

    public void Awake()
    {
        Instance = this;
    }
    public void AumentarPuntaje(int value)
    {
        score += value;
        PuntajeTexto();
    }

    public void PuntajeTexto()
    {
        puntajeTexto.text = "Puntaje: " + score.ToString();
    }
}
