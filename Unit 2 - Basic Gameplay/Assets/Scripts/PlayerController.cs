using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public GameObject projectilePrefab;
    public Transform firePoint;

    private float boundValue = 10f;

    private Vector3 moveInput;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        LevelBounds();
        PlayerMovement();
        LaunchProjectile();
    }
    private void LaunchProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, firePoint.transform.position, firePoint.transform.rotation);
        }
    }
    private void PlayerMovement()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.z = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();

        rb.velocity = moveInput * speed;
    }
    private void LevelBounds()
    {
        if (transform.position.x < -boundValue)
        {
            transform.position = new Vector3(-boundValue, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundValue)
        {
            transform.position = new Vector3(boundValue, transform.position.y, transform.position.z);
        }
    }
}
