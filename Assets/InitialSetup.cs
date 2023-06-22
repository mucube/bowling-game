// any initial setup i need is here
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialSetup : MonoBehaviour
{
    public static int knockedOver;

    void Start() {
        knockedOver = 0;
    }
}
