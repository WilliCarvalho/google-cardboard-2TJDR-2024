using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;


    public void UpdateScore(int value)
    {
        scoreText.text = $"Kills: {value}";
    }
}
