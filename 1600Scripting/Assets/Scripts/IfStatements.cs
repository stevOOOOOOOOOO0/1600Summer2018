using UnityEngine;

[CreateAssetMenu]
public class IfStatements : ScriptableObject
{

    private int a = 3;
    private int b = 3;
    private int c = 7;
    
    private void OnEnable()
    {
        if (a + b != c)
        {
            Debug.Log("True");
        }
    }
    
}
