using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    private Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f; // to decide if the ball will start going to left or right side.
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        rigidBody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        rigidBody.AddForce(force);
    }

    public void ResetPosition()
    {
        rigidBody.position = Vector2.zero;
        rigidBody.velocity = Vector2.zero;
    }
}
