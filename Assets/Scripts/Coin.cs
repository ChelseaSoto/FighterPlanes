using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter2D()
    {
		GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(1);
		Destroy(this.gameObject);
	}
}