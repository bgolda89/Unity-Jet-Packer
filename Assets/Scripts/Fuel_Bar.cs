using UnityEngine.UI;
using UnityEngine;

public class Fuel_Bar : MonoBehaviour {
	
	void Update () {
        AdjustFuelBar();
	}

    void AdjustFuelBar()
    {
        if (Player_Controller.jetPackFuel >= 0)
        {
            float ratio = Player_Controller.jetPackFuel / Player_Controller.maxJetPackFuel;
            gameObject.transform.localScale = new Vector3(ratio, 1, 1);
        }
    }
}
