using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public enum basicEmotions {
    Happy,
    Sad,
    Angry,
    Fear,
    Trust,
    Aversion,
    Anticipation
          
};

public enum complexEmotions { 
    Frustrated,
    Stressed,
    Anxiety,
    Guilt,
    Jealousy,
    Shame,
    Optimism,
    Scare,
    Disappointment,
    Remorse,
    Contempt
};


public class Emotion : MonoBehaviour {


    private basicEmotions m_BasicEmotions;
    private complexEmotions m_ComplexEmotions;



    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void init() {

    }

    public basicEmotions getBasicEmotions() {
        return m_BasicEmotions;
    }
    
    public complexEmotions getComplexEmotions() {
        return m_ComplexEmotions;
    }

    public void setBasicEmotions(basicEmotions _basicEmotion) {
        m_BasicEmotions = _basicEmotion;
    }
   
    public void setComplexEmotions(complexEmotions _complexEmotions) {
        m_ComplexEmotions = _complexEmotions;
    }
}
