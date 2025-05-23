using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare02_Script : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 maxDistance = new Vector3(8.25f, 4.42f, 5f);
    private Vector3 startPosition = new Vector3(0, 0, 0);
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(h, y, 0);
        transform.position += movement * speed * Time.deltaTime;
        Vector3 newPosition = transform.position;

        if (newPosition.x > maxDistance.x || newPosition.y > maxDistance.y || newPosition.x < (maxDistance.x * -1) || newPosition.y < (maxDistance.y * -1))
        {
            transform.position = startPosition;
        }

        



    }
}
