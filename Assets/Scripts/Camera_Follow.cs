using UnityEngine;

public class Camera_Follow : MonoBehaviour {

    private GameObject player;
    public float cameraSpeed = 5.0f;
    public float cameraSmoothing = 100.0f;

   	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update () {
        Vector3 camPos = transform.position;
        camPos.x = player.transform.position.x + 8;
        transform.position = Vector3.Lerp(transform.position, camPos, cameraSmoothing * Time.fixedDeltaTime);
        camPos.y = player.transform.position.y + 6;
        transform.position = Vector3.Lerp(transform.position, camPos, cameraSmoothing * Time.fixedDeltaTime);
	}
}
