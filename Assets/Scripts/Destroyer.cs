using UnityEngine;

public class Destroyer : MonoBehaviour
{

    public GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {
        if (player.transform.position.x - gameObject.transform.position.x > 70)
        {
            Destroy(gameObject);
        }
    }
}
