using UnityEngine;

public class Player : Entity {
	public HealthBar healthBar;
	public int maxHealth = 100;

	private void Start()
	{
		healthBar.SetMaxHealth(health);
	}
	private void Update()
	{
		if (health >= maxHealth)
		{
			health = maxHealth;
		}
		Debug.Log(health);
		healthBar.SetHealth(health);
	}

	public override void Die()
	{
		GameManager.instance.PlayerDied();
		base.Die();
	}

}
