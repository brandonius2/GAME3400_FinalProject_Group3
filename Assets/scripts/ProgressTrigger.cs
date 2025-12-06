using UnityEngine;
using System.Collections;

public class ProgressTrigger : MonoBehaviour
{
    public AudioManager am;
    public PlayerMovement pm;
    public float slowSpeed = 0.5f;

    Vector3 respawnPoint;
    public static bool isProgressing = false;

    void Awake()
    {
        respawnPoint = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("canPickUp"))
        {
            Destroy(other.gameObject);
            Debug.Log("Destroy");

            StartCoroutine(Progress());
        }

        if (other.gameObject.CompareTag("Player"))
        {
            var controller = other.GetComponent<CharacterController>();
            if (controller != null)
                controller.enabled = false;

            other.transform.position = respawnPoint;

            if (controller != null)
                controller.enabled = true;

            Debug.Log("Player respawn");
        }
    }

    private IEnumerator Progress()
    {
        Debug.Log("Start");
        isProgressing = true;
        pm.speed = slowSpeed;
        am.PlayBreathing();
        am.playAudio();
        yield return new WaitForSeconds(am.AudioLength());
        am.NextAudioReady();
        pm.speed = pm.ogspeed;
        am.StopBreathing();
        Debug.Log("End");
        isProgressing = false;
    }
}
