using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFireColumn : MonoBehaviour
{
    public float time = 5;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (time < 0)
            Destroy(gameObject);
    }
}
