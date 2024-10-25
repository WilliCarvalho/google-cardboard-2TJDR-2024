using UnityEngine;

public class Zumbi : MonoBehaviour
{
    private const float TIMETOAWAKEANIMATION = 2f;
    private float elapsedTime = 0;

    [SerializeField] private float moveSpeed;

    private Transform playerPosition;
    private Vector3 pointToLook;

    private void Start()
    {
        playerPosition = GameManager.instance.GetPlayerPosition();
        pointToLook = playerPosition.position - transform.position;
        transform.rotation = Quaternion.LookRotation(pointToLook);
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= TIMETOAWAKEANIMATION)
        {
            pointToLook = playerPosition.position - transform.position;

            transform.position = Vector3.MoveTowards(transform.position, playerPosition.position, moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(pointToLook);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Pojectile"))
        {
            GameManager.instance.UpdateScore(1);
            Destroy(this.gameObject);
        }
    }    
}
