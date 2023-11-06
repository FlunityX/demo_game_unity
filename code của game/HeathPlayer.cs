using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] int maxHealth;
    public HealthBar healthbar;
    int currentHealth;
    public UnityEvent OnDeath;

    private void OnDisable()
    {
        OnDeath.RemoveListener(Death);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.UpdateBar(currentHealth, maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
            OnDeath.Invoke();
        }
        healthbar.UpdateBar(currentHealth, maxHealth);
    }

    public void Death()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            TakeDamage(20);
        }
    }
}
