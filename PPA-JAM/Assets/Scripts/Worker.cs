using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Job { };
public enum Salary { };


public class Worker : MonoBehaviour {

    private Emotion m_Emotion;
    private Job m_job;
    private Salary m_salary;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void init(Job _job, Salary _salary) {

        m_job = _job;
        m_salary = _salary;

    }

  public Worker()
  {

  }
}
