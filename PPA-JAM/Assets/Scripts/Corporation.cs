using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corporation 
{
  //
  public List<WorkStation> workStations =  new List<WorkStation>();

  public Corporation()
  {

  }

  public void AddWorkstation(string _name)
  {
    WorkStation tmpWorkstations = new WorkStation(_name);
    workStations.Add(tmpWorkstations);
  }

  public void AddWorkstation(WorkStation _workstation)
  {
    workStations.Add(_workstation);
  }
}
