using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Observer : Puntaje
{
    public override void Score(int value)
    {
        score += value;
        GameManager.Instance.AumentarPuntaje(value);
    }
}
