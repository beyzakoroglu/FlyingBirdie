using UnityEngine;

public class BirdieScript : MonoBehaviour
{   

    public Rigidbody2D myRigidBody;  
    public float velocity = 15;  
    public LogicScript logic;
    private bool isBirdieAlive = true;
    private float birdieHeight; 
    
    // Update is called once per frame
    void Update()
    {
        
        if((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && isBirdieAlive)
        {
            myRigidBody.velocity = Vector2.up * velocity;
        }

        birdieHeight = myRigidBody.transform.position.y;
        if(birdieHeight < -12.9 && isBirdieAlive)
        {
            isBirdieAlive = false;
            logic.gameOver();
        } 
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(isBirdieAlive)
        {
            logic.gameOver();
            isBirdieAlive = false;
        }
    }

    public bool getIsBirdieAlive()
    {
        return isBirdieAlive;
    }
}
