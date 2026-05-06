using UnityEngine;

public class ChoongDol : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Door")
        {
            Destroy(collision.gameObject);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
