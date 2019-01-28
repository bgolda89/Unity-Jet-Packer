using UnityEngine;
using UnityEngine.UI;

                 
public class Score : MonoBehaviour {

    public GameObject scoreUI;
    public GameObject highScoreUI;

	void Update () {
        if (Data_Management.data_Management.coinsCollected > Data_Management.data_Management.highScore)
        {
            Data_Management.data_Management.highScore = Data_Management.data_Management.coinsCollected;
        }
        scoreUI.GetComponent<Text>().text = ("Score: " + Data_Management.data_Management.coinsCollected.ToString());
        highScoreUI.GetComponent<Text>().text = ("High Score: " + Data_Management.data_Management.highScore.ToString());
	}
}
