using UnityEngine;

public class GameInit : MonoBehaviour {

    // Use this for initialization
    public static bool gameOver;

	void Start () {
        Data_Management.data_Management.LoadData();
        gameOver = false;
	}
}
