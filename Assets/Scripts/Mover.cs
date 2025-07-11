using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{

    [SerializeField] float MoveSpeed = 0f ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime; 

        transform.Translate(xValue, yValue, zValue);
        
    }
}
