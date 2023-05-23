using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    void attach(Observer observer);
    void detach(Observer observer);
    void notify();
}