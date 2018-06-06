using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoAddition : ScriptableObject {
  //Variables

    public int C;
    
  //Functions
    private int Run(int a, int b)
    {
        return a += b;
    }

    private void OnEnable()
    {
        C = Run(10, 2);
    }
}
