using UnityEngine;

public class test : MonoBehaviour
{
    int a = 8;
    int b = 7;
    int c;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        c = a == 4 ? 6 : 7;
        Debug.Log(c);
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
