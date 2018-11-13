using PSYHO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondButton : MonoBehaviour {

    public Manager manager;
    public void click()
    {
        manager.childClass.readinessToButtonPressed = true;
    }
}
