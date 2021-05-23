﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautPlayer : PlayerController
{
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    public override void normalAttack()
    {
        Debug.Log("Astronaut normal attack!!");
        GameObject bullet = Instantiate(bulletPrefab, rb2D.position, Quaternion.identity);
        BulletController bc = bullet.GetComponent<BulletController>();
        if (bc != null)
        {
            bc.Move(lookDirection, 300);
        }
        //throw new System.NotImplementedException();
    }
}
