using UnityEngine;

public class Player_Move : MonoBehaviour {

    public int playerSpeed = 10;

	void FixedUpdate () {
        gameObject.transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
	}
}
