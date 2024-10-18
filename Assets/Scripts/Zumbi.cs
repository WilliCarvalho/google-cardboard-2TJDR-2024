using UnityEngine;

public class Zumbi : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Pojectile"))
        {
            Destroy(gameObject);
        }
    }
}
