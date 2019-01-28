using UnityEngine.SceneManagement;
using UnityEngine;

public class Load_Scene : MonoBehaviour {

    public void SceneToLoad(int scene){
        SceneManager.LoadScene(scene);
        Data_Management.data_Management.coinsCollected = 0;
        Data_Management.data_Management.SaveData();
    }
}
