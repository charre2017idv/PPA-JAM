using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Office : MonoBehaviour
{
  public List<Worker> workers = new List<Worker>();

  public Office()
  {

  }
  public void AddWorker()
  {
    Worker tmpWorker = new Worker();
    workers.Add(tmpWorker);
  }

  public void AddWorkstation(Worker _worker)
  {
    workers.Add(_worker);
  }
}
