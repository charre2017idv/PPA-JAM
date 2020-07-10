using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
  public GameController Controller;

  public GameObject Corporation;
  public GameObject WorkStationPref;
  public GameObject OfficePref;
  public GameObject WorkerPref;
  public GameObject StatsPanel;

  public List<GameObject> WorkstationList;
  public List<GameObject> OfficeList;
  

  // Start is called before the first frame update
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
    if (Controller.model.hasChange)
    {
      UpdateCorporation();  
    }
  }

  public void UpdateCorporation()
  {

    for (int i = 0; i < Controller.corporation.workStations.Count; i++)
    {
      var workstation = Controller.corporation.workStations;
      GameObject a = (GameObject)Instantiate(WorkStationPref);
      WorkstationList.Add(a);
      a.name = "Workstation "+ i;
      a.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = workstation[i].workstation_name;
			a.transform.SetParent(Corporation.transform, false);
      Controller.model.hasChange = true;
		}
      Controller.model.hasChange = false;
  }

  public void setInfo(Office office)
  {
        StatsPanel.SetActive(true);
        StatsPanel.transform.GetChild(0).GetComponent<Text>().text = office.workers[0].m_name;
        //StatsPanel.transform.GetChild(1).GetComponent<Text>().text = office.workers[0].m_Emotion.getBasicEmotions().ToString();
        StatsPanel.transform.GetChild(1).GetComponent<Text>().text = "Happy";
        //StatsPanel.transform.GetChild(2).GetComponent<Text>().text = office.workers[0].m_job.ToString();
        StatsPanel.transform.GetChild(2).GetComponent<Text>().text = "Creative";
        //StatsPanel.transform.GetChild(3).GetComponent<Text>().text = "$" + office.workers[0].m_salary.ToString();
        StatsPanel.transform.GetChild(3).GetComponent<Text>().text = "$1,000";
  }
}
