using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Office : MonoBehaviour
{
  public List<Worker> workers = new List<Worker>();

  public Office()
  {

  }
  public void AddWorker(string name)
  {
    Worker tmpWorker = new Worker(name);
    workers.Add(tmpWorker);
  }

  public void AddWorkstation(Worker _worker)
  {
    workers.Add(_worker);
  }
}
