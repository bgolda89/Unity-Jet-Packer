using UnityEngine;

public class Rotate_Object : MonoBehaviour {

    public int rotateSpeed;

	void FixedUpdate () {
        transform.Rotate(Vector3.up * rotateSpeed * Time.fixedDeltaTime);
	}
}
