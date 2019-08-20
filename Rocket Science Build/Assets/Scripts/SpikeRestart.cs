using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeRestart : MonoBehaviour
{
	public GameObject player;
	private Scene corn;

    // Start is called before the first frame update
    void Start()
    {
		corn = SceneManager.GetActiveScene();

	}

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
	{

		
		if (other.gameObject.tag == "Player")
		{
		SceneManager.LoadScene(corn.name);
		}
	}
}
