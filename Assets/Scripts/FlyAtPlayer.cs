using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3.0f;

    [SerializeField] Transform player;
    Vector3 playerPosition ;

    //The object initializes playerPosition once, that means it will move on the starting player position and stop afterwards.
    //We can make it constant following by moving line in start() into update();

    private void Awake()
    {
        this.gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        MoveToPlayer();
        DestroyWhenReached();

    }
    
    void MoveToPlayer() 
    {
        transform.position = Vector3.MoveTowards(transform.position,playerPosition, moveSpeed * Time.deltaTime);
    }

    void DestroyWhenReached() 
    {
        if (transform.position == playerPosition) 
        {
            Destroy(this.gameObject);
            Debug.Log("GameObject has been terminated");
        }
            
    }
}
