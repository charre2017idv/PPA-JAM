﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum Job { };
public enum Salary { };


public class Worker : MonoBehaviour {
    public string m_name;
    public Emotion m_Emotion;
    public Job m_job;
    public Salary m_salary;
    private bool m_isWalking;
    //public GameObject ownWorker;
    private float limits = 74;
    float posX;

    RectTransform Rect;

    // Start is called before the first frame update
    void Start()
    {
        Rect = gameObject.GetComponent<RectTransform>();
        
        posX = Rect.position.x;
        limits += posX;
        m_isWalking = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (!m_isWalking)
        {
            walk();
        }
    }

    public void init(Job _job, Salary _salary)
    {

        m_job = _job;
        m_salary = _salary;

    }


    public Worker() {
        m_name = "Chucho";
        
    }

    void walk() {
        m_isWalking = true;
        
        Debug.Log(posX);
        if (posX > -limits && posX < limits)
        {
            Debug.Log("Dentro del rango");

            float newPos = 0.4f;
            Rect.position += new Vector3(newPos, 0, 0);
        }
        if (posX <= -limits || posX >= limits)
        {

            float newPos = 0.0f;
            if (posX < 0) { newPos = 0.4f; }
            else if (posX > 0) { newPos = -0.4f; }
            Rect.position += new Vector3(newPos, 0, 0);
            if (posX == 0)
            {
                m_isWalking = false;
            }
        }


        m_isWalking = false;
    }

    void getInfo(GameObject inUIPanel) {
        
       // m_Emotion
       // m_job
       // m_salary
    }

}
