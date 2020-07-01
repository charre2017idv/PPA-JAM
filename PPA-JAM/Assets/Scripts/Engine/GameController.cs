using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
  // Game model for the game
  [HideInInspector]
  public GameModel model;
  // Coporation
  [HideInInspector]
  public Corporation corporation = new Corporation();

  public int amountWorkstations;
  public void Init()
  {
  }

  public void Awake()
  {
    amountWorkstations = 3;
    model = new GameModel(this);
  }

  // Start is called before the first frame update
  void Start()
  {  
  }

    // Update is called once per frame
    void Update()
    {
        
    }
}
