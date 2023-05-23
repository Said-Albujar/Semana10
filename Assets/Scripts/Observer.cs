using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Observer : Puntaje
{
    public override void CambioPuntaje(int value)
    {
        score += value;
        GameManager.instance.Aumentar(score);
    }
}
