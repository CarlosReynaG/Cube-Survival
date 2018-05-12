using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {

    public Transform player;
    public Text scoreDisplay;


	// Update is called once per frame
	void Update () {
        scoreDisplay.text = player.position.z.ToString("0");
	}
}
