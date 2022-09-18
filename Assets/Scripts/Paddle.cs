using UnityEngine;

public class Paddle : MonoBehaviour
{ 
    public float speed = 1f;
    protected Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        rigidBody.position = new Vector2(rigidBody.position.x, 0.0f);
        rigidBody.velocity = Vector2.zero;
    }
}