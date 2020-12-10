using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    private Player player;
	private float health = 100;
	public static string ENEMY_TAG = "Enemy";
	
	// Start is called before the first frame update
    void Start() {
		this.SetPlayer(GameObject.FindWithTag(Player.PLAYER_TAG).GetComponent<Player>());
    }
	
	void OnTriggerEnter(Collider other)
    {
        health -= 100;
    }

	void Update()
	{
		if(health <= 0)
		{
			Destroy(gameObject);
		}
	}
	
	public void SetPlayer(Player player) {
		this.player = player;
	}
	public Player GetPlayer() {
		return this.player;
	}
}
