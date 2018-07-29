using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public float enemyHealth;
	// Use this for initialization
	void Start () {
        enemyHealth = 1f;

    }
	
	// Update is called once per frame
	void Update () {
		if (enemyHealth < 1)
        {
            Destroy(gameObject);
        }
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerStandardBulletTrigger")) 
            {
            enemyHealth = enemyHealth - 1;
        }
    }
}
