using UnityEngine;

public class Destroy : MonoBehaviour
{
    Vector3 respawnPoint;

    void Awake()
    {
        respawnPoint = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("canPickUp"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Destroy");
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.position = respawnPoint;
            Debug.Log("Player respawn");
        }
    }
}
