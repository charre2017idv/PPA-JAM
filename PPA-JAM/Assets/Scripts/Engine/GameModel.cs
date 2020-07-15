using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : MonoBehaviour
{
  public bool hasChange = false;
  public List<Worker> WorkersList = new List<Worker>();

    // Start is called before the first frame update
    void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
      
  }


  public GameModel(GameController _controller)
  {
    for (int i = 0; i < _controller.amountWorkstations; i++)
    {
      _controller.corporation.AddWorkstation("WorkStation " + i);
    }

    _controller.corporation.workStations[0].AddOffice();
    _controller.corporation.workStations[0].offices[0].AddWorker("Profe Hector");
    WorkersList.Add(_controller.corporation.workStations[0].offices[0].workers[0]);
    
    hasChange = true;
  }


}
