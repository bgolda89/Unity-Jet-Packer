using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class Data_Management : MonoBehaviour {

    public static Data_Management data_Management;
    public int currentScore;
    public int highScore;
    public int coinsCollected; 


	void Awake () {
        if (data_Management == null)
        {
            DontDestroyOnLoad(gameObject);
            data_Management = this;
        }
        else if (data_Management != this)
        {
            Destroy(gameObject);
        }
	}

    public void SaveData ()
    {
        BinaryFormatter binaryForm = new BinaryFormatter ();
        FileStream file = File.Create(Application.persistentDataPath + "/gameInfo.dat");
        gameData data = new gameData();
        data.highScore = highScore;
        data.coinsCollected = coinsCollected;
        binaryForm.Serialize(file, data);
        file.Close ();
    }

    public void LoadData()
    {
        if (File.Exists (Application.persistentDataPath + "/gameInfo.dat"))
        {
            BinaryFormatter binaryForm = new BinaryFormatter ();
            FileStream file = File.Open(Application.persistentDataPath + "/gameInfo.dat", FileMode.Open);
            gameData data = (gameData)binaryForm.Deserialize(file);
            file.Close();
            highScore = data.highScore;
            coinsCollected = data.coinsCollected;
            Debug.Log("loaded data");
        }
    }
}

[Serializable]
class gameData {
    public int highScore;
    public int coinsCollected;
}
