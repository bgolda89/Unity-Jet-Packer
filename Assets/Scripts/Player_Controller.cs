using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public AudioClip jet;
    public static float jetPackFuel = 2f;
    public static float maxJetPackFuel = 2f;
    public float jetPackForce = 250.0f;
    public GameObject jetpack;
    public ParticleSystem smoke;

    private void Start()
    {
        jetPackFuel = 2f;
    }

    void Update () {
        if (Input.GetButton("Jump") && jetPackFuel > 0) 
        {
            BoostUp();
            jetpack.GetComponent<ParticleSystem>().Play(smoke);
        } else
            jetpack.GetComponent<ParticleSystem>().Stop(smoke);
	}

    void BoostUp() 
    {
        jetPackFuel = Mathf.MoveTowards(jetPackFuel, 0, Time.fixedDeltaTime);
        GetComponent<Rigidbody>().AddForce(new Vector3(0, jetPackForce, 0));
        GetComponent<AudioSource>().PlayOneShot(jet, 0.2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        jetPackFuel = maxJetPackFuel;
    }
}
