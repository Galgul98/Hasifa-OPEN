using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{
    public static Globals globals;
    public static string level = "Level";
    void Start()
    {
        globals = this;
    }
}
