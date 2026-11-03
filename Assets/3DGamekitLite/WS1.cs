using UnityEngine;

public class WS1 : MonoBehaviour
{

    public int myNumber = 0;
    private Rigidbody2D rb;
    
    // Variabler:
    bool exampleBool = true; // Påstående
    string exampleString = "Hello World"; // Meddelande
    float exampleFloat = 123.456f; // Decimaltal
    int exampleInt = 123; // Heltal

    
    // Metoder:
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            YSpeed();
        }
    }

    public void YSpeed()
    {
        if (myNumber == 39)
        {
            rb.linearVelocityY = 3f;
        }
        else
        {
            Debug.Log(myNumber);
        }
    }
   
    
}
