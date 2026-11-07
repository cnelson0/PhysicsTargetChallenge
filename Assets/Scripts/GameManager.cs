using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    public int targetScore = 3;
    public TMP_Text scoreText;

    void Start()
    {
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score " + score;
    }
    void Awake()
    {
        Instance = this;
    }
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI(); 
        Debug.Log("Score: " + score);
        if (score >= targetScore)
        {
            Debug.Log("You Win!");
        }
    }

    public enum GameState
    {
        Playing,
        Won,
        Lost    
    }
    public GameState currentState = GameState.Playing;

    public int ammo = 10;

    public bool CanShoot()
    {
        return currentState == GameState.Playing && ammo > 0;
    }

    public void UseAmmo()
    {
        ammo--;

        if (ammo == 0 && score < targetScore)
        {
            currentState = GameState.Lost;
            Debug.Log("Game Over!");
        }
    }
}
