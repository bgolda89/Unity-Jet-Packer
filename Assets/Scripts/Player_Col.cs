using UnityEngine;

public class Player_Col : MonoBehaviour {

    public GameObject restartUI;
    public AudioClip death, coin;
    public ParticleSystem smoke;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            PlayerDies();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            //play sound, increase coin collection
            GetComponent<AudioSource>().PlayOneShot(coin, 0.2f);
            Destroy(other.gameObject);
            Data_Management.data_Management.coinsCollected++;

        }
    }

    void PlayerDies()
    {
        if (Data_Management.data_Management.coinsCollected > Data_Management.data_Management.highScore)
        {
            Data_Management.data_Management.highScore = Data_Management.data_Management.coinsCollected;
        }
        GetComponent<AudioSource>().PlayOneShot(death, 0.3f);
        GetComponent<Player_Controller>().enabled = false;
        GetComponent<Player_Move>().enabled = false;
        Data_Management.data_Management.SaveData();
        restartUI.gameObject.SetActive(true);
        GetComponent<ParticleSystem>().Play(smoke);
        GameInit.gameOver = true;
    }
}
