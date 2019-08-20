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

    void OnCollisionEnter(Collision other)
	{
		if (other.transform.gameObject.name == player.name)
		{
			SceneManager.LoadScene(corn.name);
		}
	}
}
