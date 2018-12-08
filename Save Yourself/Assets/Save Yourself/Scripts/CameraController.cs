using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform playerTransform;
    private float smooth = 0.75f;
    private Vector3 velocity = new Vector3(0, 0, 0);
    private Vector3 pos = new Vector3();
    private Camera cam;

    // Use this for initialization
    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        SmoothFollow();
    }

    private void SmoothFollow()
    {
        pos.x = playerTransform.position.x;
        pos.y = playerTransform.position.y + 12.75f;
        pos.z = playerTransform.position.z - 10f;

        cam.transform.position = Vector3.SmoothDamp(cam.transform.position, pos, ref velocity, smooth);
    }
}
