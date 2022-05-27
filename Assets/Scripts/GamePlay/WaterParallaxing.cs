using UnityEngine;

public class WaterParallaxing : MonoBehaviour {

	public SpriteRenderer sr;

	// Update is called once per frame
	void Update () {
		sr.material.SetVector("_PlayerPos", PlayerController.Position);
	}
}
