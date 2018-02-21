using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
    LevelManager levelmanager;

	// Use this for initialization
	void Start () {
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
        transform.position = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
            if (transform.position.x + Input.GetAxis("hor") * speed * Time.deltaTime < 10 &&
                transform.position.x + Input.GetAxis("hor") * speed * Time.deltaTime > -10)
            {
                transform.Translate(Input.GetAxis("hor") * speed * Time.deltaTime, 0, 0);
            }
            if (transform.position.y + Input.GetAxis("ver") * speed * Time.deltaTime < 3.375 &&
                transform.position.y + Input.GetAxis("ver") * speed * Time.deltaTime > -3.375)
            {
                transform.Translate(0, Input.GetAxis("ver") * speed * Time.deltaTime, 0, 0);
            }
        }
    void OnTriggerEnter2D(Collider2D other)
        {
        if (other.transform.name == "Door")
        {
            levelmanager.LoadNextLevel();
        }
    }
}
