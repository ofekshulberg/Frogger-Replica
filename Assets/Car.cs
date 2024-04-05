using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;

    public float minSpeed = 2f;
    public float maxSpeed = 6f;

    float speed = 1f;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }

    public void AdjustSpeed(float speedIncrement)
    {
        minSpeed += speedIncrement;
        maxSpeed += speedIncrement;
    }

    public void SetOriginalSpeed(float minOriginal, float maxOriginal)
    {
        minSpeed = minOriginal;
        maxSpeed = maxOriginal;
    }
}
