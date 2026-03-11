using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string playerName;
    void Start()
    {
        Debug.Log("Hello" + playerName);
        Debug.LogError("Hello World!!");
        Debug.LogWarning("Hello world!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
