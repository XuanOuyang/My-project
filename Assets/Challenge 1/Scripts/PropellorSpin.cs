using UnityEngine;

public class PropellorSpin : MonoBehaviour
{
    public float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime * speed);
    }
}
