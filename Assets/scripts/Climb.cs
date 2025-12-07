using UnityEngine;
using TMPro;

public class Climb : MonoBehaviour
{
    public TMP_Text interactText;
    public Transform teleportPoint;
    public bool InRange { get; private set; } = false;

    // Update is called once per frame
    void Update()
    {
        if (InRange && Input.GetKeyDown(KeyCode.E))
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            var controller = player.GetComponent<CharacterController>();
            if (controller != null)
                controller.enabled = false;

            player.transform.position = teleportPoint.position;

            if (controller != null)
                controller.enabled = true;

            interactText.enabled = false;
            InRange = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            interactText.enabled = true;
            InRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactText.enabled = false;
            InRange = false;
        }
    }
}
