using UnityEngine;
public class Target : MonoBehaviour
{
    public static int score = 0;
    public int maxHealth = 3;
    private int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void Hit()
    {
        currentHealth--;
        Debug.Log("Health remaining: " + currentHealth);
        if (currentHealth <= 0)
        {
            GameManager.Instance.AddScore(1);
            //score++;
            //Debug.Log("Target destroyed! Score: " + score);
            Destroy(gameObject);

        }
    }
}