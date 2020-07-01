using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkStation : MonoBehaviour
{
  public List<Office> offices = new List<Office>();
  public string workstation_name;
  public WorkStation(string _name)
  {
    workstation_name = _name;
  }
  public void AddOffice()
  {
    Office tmpOffice = new Office();
    offices.Add(tmpOffice);
  }

  public void AddOffice(Office _office)
  {
    offices.Add(_office);
  }
}
