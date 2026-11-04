using UnityEngine;
using Gamekit3D;

public class HungerManager : MonoBehaviour
{
    
    private float timer = 0;

    private void DealDamage()
    {
        Damageable.DamageMessage dmg = new Damageable.DamageMessage
        {
            amount = 1,
            damager = this,
            direction = Vector3.zero,
            damageSource = Vector3.zero,
            throwing = false,
            stopCamera = false, 
            ;
        };
    }

    
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer >= 10)
            { 
                timer = 0;
            }
            
        }
    
}
