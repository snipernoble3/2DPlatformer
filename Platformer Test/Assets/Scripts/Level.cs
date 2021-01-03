using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level {

    public string name { get; } //level name
    //GameManager.Difficulty difficulty; //level difficulty    
    //preview image
    public int buildIndex { get; } //build/scene index
    public bool completed { get; } //has the player copleted this level
    public int stars { get; } //number of stars/checkpoints reached



}
