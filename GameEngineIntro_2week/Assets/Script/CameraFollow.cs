using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    float cameraOffest = -10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y, cameraOffest);
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime);
    }
}
