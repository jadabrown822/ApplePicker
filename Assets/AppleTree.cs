using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    // Prefab for instantiating apples
    public GameObject applePrefab;
    public GameObject branchPrefab;


    // Speed at which the AppleTree moves
    public float speed = 5f;


    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;


    // Chance that the AppleTree will change directions
    public float changeDirChance = 0.1f;


    // Seconds between Apple instantiations
    public float appleDropDelay = 1f;
    public float branchDropDelay = 1f;


    // the minimum and maximum values for  the random number range
    public float minFloat = 1.0f;
    public float maxFloat = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropSomething", 2f);
    }


    void DropSomething()
    {
        float randomNumber = Random.Range(minFloat, maxFloat);

        if (randomNumber < 2)
        {
            DropBranch();
        }
        else
        {
            DropApple();
        }

        Invoke("DropSomething", Random.Range(appleDropDelay, branchDropDelay));
    }


    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
    }


    void DropBranch()
    {
        GameObject branch = Instantiate<GameObject>(branchPrefab);
        branch.transform.position = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing Directions
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);       // Move Right
        }

        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);      // Move Left
        }

        /* else if (Random.value < changeDirChance)
        {
            speed *= -1;        // Change Direction
        }
        */
    }


    void FixedUpdate()
    {
        // Random direction changes are now time-based due to FixedUpdate()
        if (Random.value < changeDirChance)
        {
            speed *= -1;        // Change direction
        }
    }
}
