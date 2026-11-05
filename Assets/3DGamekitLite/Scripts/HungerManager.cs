using UnityEngine;
using Gamekit3D;

public class HungerManager : MonoBehaviour
{    
        private float timer = 0f;
        [SerializeField] private Damageable damageTarget;
        [SerializeField] private float damageTime = 10f;
        [SerializeField] private int damageAmount = 1;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer >= damageTime)
            {
                Damageable.DamageMessage msg = new Damageable.DamageMessage()
                {
                    damager = this,
                    amount = damageAmount,
                    damageSource = new Vector3(x: 0, y: 0, z: 0).normalized,
                    direction = new Vector3(x: 0, y: 0, z: 0).normalized,
                    throwing = false,
                    stopCamera = false
                };
                
                damageTarget.ApplyDamage(msg);
                ResetTimer();
            }
        }

        public void ResetTimer()
        {
            timer = 0f;
        }
    
}
