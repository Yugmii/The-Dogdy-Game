using Unity.Collections;
using UnityEngine;

public class Spinner : MonoBehaviour

{

    [SerializeField] float x = 2.5f;
    [SerializeField] float y = 0f;
    [SerializeField] float z = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x, y, z);
    }
}
