using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
	public PlayerHealth playerHealth;
	public GameObject enemy;
	public Text text;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;

	private int wave = 1;

	//private GameObject[] getCount;
	//private int count;
	//private int sk_produced=0;
	//private int sk_wave=5;
	//private int sk_dead;
	//private bool production=true;


	void Start ()
	{
		//getCount = GameObject.FindGameObjectsWithTag("Skeleton");
		//count = getCount.Length;
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void Spawn ()
	{
		//while (playerHealth.currentHealth > 0) {
			//(){

				//text.text = "Wave " + wave;
			//}
			
		//}

		if(playerHealth.currentHealth <= 0f)
		{
			return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		//if (production){

			Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
			//sk_produced+=1;
			//if(sk_produced==sk_wave){
			//	production=false;
			//}
		//}
		//if(count==sk_dead){
		//	production=true;
		//}
	}
}
