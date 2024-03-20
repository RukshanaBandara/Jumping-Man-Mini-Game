using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce;

    private Rigidbody2D _rBody;

    public GameObject gameOverPanel;

    private void Awake()
    {
        _rBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Jump();
        PlayerBound();
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rBody.velocity = new Vector2(0, jumpForce);
        }
    }
    private void PlayerBound()
    {
        if (transform.position.y >= 3.55f)
        {
            transform.position = new Vector2(0, 3.55f);
        }
    }
    // identify trigger

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.CompareTag("Arrow"))
        {
            gameOverPanel.SetActive(true);

            Time.timeScale = 0;
        }
    } 

}//class
