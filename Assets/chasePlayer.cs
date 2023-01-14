using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chasePlayer : MonoBehaviour
{
    public Transform player;
    public GameObject colliderObject;
    public float speed = 2f;
    private Collider collider;
    private Vector3 randomPosition;
    public float waitTime = 5f;
    private float timer;

    void Start()
    {
        collider = colliderObject.GetComponent<Collider>();
        randomPosition = GetRandomPosition();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.transform;
        }
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
        else
        {
            timer += Time.deltaTime;
            if (timer >= waitTime)
            {
                randomPosition = GetRandomPosition();
                timer = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position, randomPosition, speed * Time.deltaTime);
        }

        if (!collider.bounds.Contains(transform.position))
        {
            transform.position = collider.ClosestPoint(transform.position);
        }
    }

    Vector3 GetRandomPosition()
    {
        Vector3 randomPos = collider.bounds.center + new Vector3(
            (Random.value - 0.5f) * collider.bounds.extents.x,
            (Random.value - 0.5f) * collider.bounds.extents.y,
            (Random.value - 0.5f) * collider.bounds.extents.z
        );
        return randomPos;
    }
}
