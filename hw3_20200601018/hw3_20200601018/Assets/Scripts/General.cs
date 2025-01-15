using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class General : MonoBehaviour
{
    public Enemy enemy;
    
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI ammoText;

    public int health;
    public int ammo;

    public int damageEnemyGive;
    public int healthpackHpIncrease = 50;
    public int maxAmmo = 10;

    public void Awake()
    {
        updateAmmo();
        updateHealth();
    }

    public void takeDamage()
    {
        health -= damageEnemyGive;
        if (health < 0)
        {
            health = 0;
        }
        updateHealth();
    }

    public void useHealthpack()
    {
        health += healthpackHpIncrease;
        if (health > 100)
        {
            health = 100;
        }
        updateHealth();
    }

    public void updateHealth()
    {
        healthText.text = ("Hp: " + health);
    }

    public void reload()
    {
        ammo = maxAmmo;
        updateAmmo();
    }

    public void shoot()
    {
        if (ammo > 0)
        {
            enemy.enemyCoroutineCaller();
            ammo--;
            updateAmmo();
        }
    }
    
    public void updateAmmo()
    {
        ammoText.text = ("Ammo: " + ammo);
    }
}
