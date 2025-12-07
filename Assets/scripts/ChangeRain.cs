using UnityEngine;

public class ChangeRain : MonoBehaviour
{
    ParticleSystem particle;
    Color originalColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        particle = gameObject.GetComponent<ParticleSystem>();
        if (particle)
            originalColor = particle.startColor;
    }

    // Update is called once per frame
    void Update()
    {
        if(ProgressTrigger.isProgressing && particle)
        {
            particle.startColor = Color.red;
        } 
        else
        {
            particle.startColor = originalColor;
        }
    }
}
