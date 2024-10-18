using UnityEngine;

public class Jogador : MonoBehaviour
{
    [SerializeField] private Projectile projectilePrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Atirar();
        }
    }



    private void Atirar()
    {
        Debug.Log("Atirando");
        Instantiate(projectilePrefab, Camera.main.transform.position, Camera.main.transform.rotation);
    }
}
