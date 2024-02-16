using UnityEngine;

public class Movement : MonoBehaviour
{   
    public float moveSpeed = 0.5f;
    private float deadZone = -33;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; //delta time ile çarpmazsak fps'in değişime bağlı güncellenen 
                                                                                               //bir hızımız olur biz her bilgisayarda aynı hızda ilerlemesini istiyoruz
    
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
