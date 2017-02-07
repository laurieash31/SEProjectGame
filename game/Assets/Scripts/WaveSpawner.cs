using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour  {

    public Transform enemy1;
	public Transform enemy2;
	public Transform enemy3;
	public Transform enemy4;

    public Transform spawnPoint1;
	public Transform spawnPoint2;
	public Transform spawnPoint3;
	public Transform spawnPoint4;
	public Transform spawnPoint5;
	public Transform spawnPoint6;
	public Transform spawnPoint7;
	public Transform spawnPoint8;
	public Transform spawnPoint9;
	public Transform spawnPoint10;
	public Transform spawnPoint11;
	public Transform spawnPoint12;

	public static int totalScore = 500;
	public int totalHealth = 100;

	public static int addedScore;
	public static int addedDamage;

	public Text scoreText;
	public Text healthText;

    public float timeBetweenWaves = 5f;

    private float countdown = 2f;

	private int waveNumber = 3;
	private int spawnLocation;
	public static int numberOfEnemies;
	public int number;
	public int cubert_number = 0;
	public int chez_number = 4;
	public int spear_number = 4;

	void Update ()
    {
		number = numberOfEnemies;
		AddScoreChez ();
		AddScoreCubert ();
		AddDamage ();
		AddScoreSpear();

		if ( numberOfEnemies <= 0)
        {
			StartCoroutine(SpawnWave());
			waveNumber++;	
			cubert_number = 0;
			chez_number = 4;
			spear_number = 4;
        }


    }

	IEnumerator SpawnWave()
	{
		
		if (waveNumber > 4){
				cubert_number = cubert_number  - (waveNumber - 3);
			}
		while (cubert_number < waveNumber) {
			SpawnEnemy1();
			numberOfEnemies++;
			cubert_number++;
			yield return new WaitForSeconds (2f);
		}
		if (waveNumber > 3) {
			if (waveNumber > 8){
			chez_number = chez_number  - (waveNumber);
			}
			while (chez_number < waveNumber) {
				SpawnEnemy2();
				numberOfEnemies++;
				chez_number++;
				yield return new WaitForSeconds (2f);
		}
		}
		if (waveNumber > 4) {
			if (waveNumber > 6){
			spear_number = spear_number  - (waveNumber);
			}
			while (spear_number < waveNumber) {
				SpawnEnemy3();
				numberOfEnemies++;
				spear_number++;
				yield return new WaitForSeconds (2f);
		}
		}
	}
    void SpawnEnemy1()
	{
		spawnLocation = Random.Range (0, 12);
		switch (spawnLocation) {
		case 0:
			Instantiate (enemy1, spawnPoint1.position, spawnPoint1.rotation);
			break;
		case 1:
			Instantiate (enemy1, spawnPoint2.position, spawnPoint2.rotation);
			break;
		case 2:
			Instantiate (enemy1, spawnPoint3.position, spawnPoint3.rotation);
			break;
		case 3:
			Instantiate (enemy1, spawnPoint4.position, spawnPoint4.rotation);
			break;
		case 4:
			Instantiate (enemy1, spawnPoint5.position, spawnPoint5.rotation);
			break;
		case 5:
			Instantiate (enemy1, spawnPoint6.position, spawnPoint6.rotation);
			break;
		case 6:
			Instantiate (enemy1, spawnPoint7.position, spawnPoint7.rotation);
			break;
		case 7:
			Instantiate (enemy1, spawnPoint8.position, spawnPoint8.rotation);
			break;
		case 8:
			Instantiate (enemy1, spawnPoint9.position, spawnPoint9.rotation);
			break;
		case 9:
			Instantiate (enemy1, spawnPoint10.position, spawnPoint10.rotation);
			break;
		case 10:
			Instantiate (enemy1, spawnPoint11.position, spawnPoint11.rotation);
			break;
		default:
			Instantiate (enemy1, spawnPoint12.position, spawnPoint12.rotation);
			break;
		}
	}
		void SpawnEnemy2()
		{
			spawnLocation = Random.Range (0, 12);
			switch (spawnLocation) {
		case 0:
			Instantiate (enemy2, spawnPoint1.position, spawnPoint1.rotation);
			break;
		case 1:
			Instantiate (enemy2, spawnPoint2.position, spawnPoint2.rotation);
			break;
		case 2:
			Instantiate (enemy2, spawnPoint3.position, spawnPoint3.rotation);
			break;
		case 3:
			Instantiate (enemy2, spawnPoint4.position, spawnPoint4.rotation);
			break;
		case 4:
			Instantiate (enemy2, spawnPoint5.position, spawnPoint5.rotation);
			break;
		case 5:
			Instantiate (enemy2, spawnPoint6.position, spawnPoint6.rotation);
			break;
		case 6:
			Instantiate (enemy2, spawnPoint7.position, spawnPoint7.rotation);
			break;
		case 7:
			Instantiate (enemy2, spawnPoint8.position, spawnPoint8.rotation);
			break;
		case 8:
			Instantiate (enemy2, spawnPoint9.position, spawnPoint9.rotation);
			break;
		case 9:
			Instantiate (enemy2, spawnPoint10.position, spawnPoint10.rotation);
			break;
		case 10:
			Instantiate (enemy2, spawnPoint11.position, spawnPoint11.rotation);
			break;
		default:
			Instantiate (enemy2, spawnPoint12.position, spawnPoint12.rotation);
			break;
		}

			}
		void SpawnEnemy3()
		{
			spawnLocation = Random.Range (0, 12);
			switch (spawnLocation) {
		case 0:
			Instantiate (enemy3, spawnPoint1.position, spawnPoint1.rotation);
			break;
		case 1:
			Instantiate (enemy3, spawnPoint2.position, spawnPoint2.rotation);
			break;
		case 2:
			Instantiate (enemy3, spawnPoint3.position, spawnPoint3.rotation);
			break;
		case 3:
			Instantiate (enemy3, spawnPoint4.position, spawnPoint4.rotation);
			break;
		case 4:
			Instantiate (enemy3, spawnPoint5.position, spawnPoint5.rotation);
			break;
		case 5:
			Instantiate (enemy3, spawnPoint6.position, spawnPoint6.rotation);
			break;
		case 6:
			Instantiate (enemy3, spawnPoint7.position, spawnPoint7.rotation);
			break;
		case 7:
			Instantiate (enemy3, spawnPoint8.position, spawnPoint8.rotation);
			break;
		case 8:
			Instantiate (enemy3, spawnPoint9.position, spawnPoint9.rotation);
			break;
		case 9:
			Instantiate (enemy3, spawnPoint10.position, spawnPoint10.rotation);
			break;
		case 10:
			Instantiate (enemy3, spawnPoint11.position, spawnPoint11.rotation);
			break;
		default:
			Instantiate (enemy3, spawnPoint12.position, spawnPoint12.rotation);
			break;
		}
		}
	void AddScoreCubert(){
		addedScore = DeathofCubert.newScore;
		totalScore += addedScore;
		scoreText.text = "Points: " + totalScore;
		DeathofCubert.newScore = 0;
	}
	void AddScoreChez(){
		addedScore = DeathofChez.newScore;
		totalScore += addedScore;
		scoreText.text = "Points: " + totalScore;
		DeathofChez.newScore = 0;
	}
	void AddScoreSpear(){
		addedScore = DeathofSpear.newScore;
		totalScore += addedScore;
		scoreText.text = "Points: " + totalScore;
		DeathofSpear.newScore = 0;
	}

	void AddDamage(){
		addedDamage = DeathforPlayer.damage;
		totalHealth -= addedDamage;
		healthText.text = "Health: " + totalHealth;
		DeathforPlayer.damage = 0;
	}

}
