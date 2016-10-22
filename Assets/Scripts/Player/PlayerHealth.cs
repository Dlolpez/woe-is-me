using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
	public int startingHealth = 100;
	public int currentHealth;
	public Slider healthSlider;
	public Image damageImage;
	public AudioClip deathClip;
	public float flashSpeed = 5f;
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);


	Animator anim;
	PlayerMovement playerMovement;
	PlayerShooting playerShooting;
	bool isDead;
	bool damaged;
	GameObject kit;


	void Awake ()
	{
		kit = GameObject.FindGameObjectWithTag ("kit");
		anim = GetComponent <Animator> ();
		playerMovement = GetComponent <PlayerMovement> ();
		playerShooting = GetComponentInChildren <PlayerShooting> ();
		currentHealth = startingHealth;
        healthSlider.value = currentHealth;
    }
	
	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == kit )
		{
			Destroy(other.gameObject);
			currentHealth += 100;
			healthSlider.value = currentHealth;

		}
	}

	void Update ()
	{
		if(damaged)
		{
			damageImage.color = flashColour;
		}
		else
		{
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
	}


	public void TakeDamage (int amount)
	{
		damaged = true;

		currentHealth -= amount;

		healthSlider.value = currentHealth;

		//playerAudio.Play ();

		if(currentHealth <= 0 && !isDead)
		{
			Death ();
            Wait();
            RestartLevel();

        }
	}


	void Death ()
	{
		isDead = true;

		playerShooting.DisableEffects ();

		anim.SetTrigger ("Die");

		playerMovement.enabled = false;
		playerShooting.enabled = false;
        
    }


	public void RestartLevel ()
	{
        int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (scene, LoadSceneMode.Single);
	}

    IEnumerator Wait() {
        yield return new WaitForSeconds(5f);
    }
}
