using UnityEngine;

public class Jogador : MonoBehaviour
{
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private Transform shootPosition;

    [SerializeField] private int lives = 0;

    private void Start()
    {
        GameManager.instance.UpdateLives(lives);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && lives > 0)
        {
            Atirar();
        }
    }

    private void Atirar()
    {
        Debug.Log("Atirando");
        Instantiate(projectilePrefab, shootPosition.position, Camera.main.transform.rotation);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Zumbi"))
        {
            lives--;
            GameManager.instance.UpdateLives(lives);
            CheckIsAlive();
        }
    }

    private void CheckIsAlive()
    {
        if (lives > 0) return;
        GameManager.instance.GameOver();
    }
}
