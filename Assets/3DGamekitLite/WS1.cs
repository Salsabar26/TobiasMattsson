using UnityEngine;
using UnityEngineInternal;
using Gamekit3D;
using UnityEngine.Events;

public class WS1 : MonoBehaviour
{

    public int myNumber = 0;
    private Rigidbody2D rb;
    public UnityEvent onStart;
    private float timer = 0;
    
    // Variabler:
    bool exampleBool = true; // Påstående
    string exampleString = "Hello World"; // Meddelande
    float exampleFloat = 123.456f; // Decimaltal
    int exampleInt = 123; // Heltal

    
    // Metoder:
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            onStart.Invoke();
            myNumber++;
            rb = GetComponent<Rigidbody2D>();
            myNumber = Random.Range(0, 10);
            Debug.Log(myNumber);

            for (int counter = 0; counter < 10; counter++)
            {
                Debug.Log(counter);
            }
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            YSpeed();
        }
        timer =+ Time.deltaTime;
        Debug.Log(timer);
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
