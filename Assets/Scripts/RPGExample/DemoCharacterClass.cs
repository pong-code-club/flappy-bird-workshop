using UnityEngine;

public class DemoCharacterClass : MonoBehaviour
{
    public int MyHealthPower;
    public int MyGoldCount;
    public float MySpeed;
    //event function that automatically runs once when the game starts
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // event function that automatically run every update or heartbeat
    // Update is called once per frame
    void Update()
    {
        
    }

    // event function that automatically run anytime this game object intersects with another game object   
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit another character");

        //use a function
        //TakeDamage();

        //if I hit the enemy, then call TakeDamage
        if (collision.gameObject.name == "Enemy")
        {
            TakeDamage();
        }

        //if I hit the coin, then call GetCoin
        if (collision.gameObject.name == "Coin")
        {
            GetCoin();
        }
    }

    //declaring a function
    public void MyAttack()
    {
        
    }

    //declaring a function
    public void TakeDamage()
    {
        MyHealthPower = MyHealthPower - 1;
    }

    //declaring a function
    public void GetCoin()
    {
        MyGoldCount = MyGoldCount + 1;
    }
}
