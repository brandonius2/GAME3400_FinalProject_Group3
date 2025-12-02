using UnityEngine;

public class Water : MonoBehaviour
{
    public float scrollSpeedX = 0.1f;
    public float scrollSpeedY = 0.1f;

    Material mat;
    Vector2 offset;

    void Awake()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset.x += scrollSpeedX * Time.deltaTime;
        offset.y += scrollSpeedY * Time.deltaTime;

        mat.SetTextureOffset("_BaseMap", offset);
    }
}
