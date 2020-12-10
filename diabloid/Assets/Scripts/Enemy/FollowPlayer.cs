using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : Enemy {
	public float speed = 5f;
 
	void Update() {
		Vector3 playerPos = new Vector3(
			this.GetPlayer().transform.position.x, 
			this.GetPlayer().transform.position.y, 
            this.GetPlayer().transform.position.z
		);
		transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
	}

}
