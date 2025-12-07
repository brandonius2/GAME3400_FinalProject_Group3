using UnityEngine;
using TMPro;

public class PickUpCrate : MonoBehaviour
{
    public TMP_Text interactText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactText.enabled = true;


            var pickUp = Camera.main.GetComponent<PickUp>();
            if (pickUp)
            {
                pickUp.currentCrate = gameObject;
                pickUp.pickUpCrate = this;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactText.enabled = false;

            var pickUp = Camera.main.GetComponent<PickUp>();
            if (pickUp)
            {
                pickUp.currentCrate = null;
                pickUp.pickUpCrate = null;
            }
        }
    }
}
