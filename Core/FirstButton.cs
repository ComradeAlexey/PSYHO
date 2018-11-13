using PSYHO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstButton : MonoBehaviour
{
    public Manager manager;
    public void click()
    {
        manager.childClass.readinessToButtonPressed = true;
    }
}