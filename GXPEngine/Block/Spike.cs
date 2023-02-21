﻿using GXPEngine;
using GXPEngine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiledMapParser;

public class Spike : AnimationSpriteAddOn
{
    public event Action GroundSpawnEvent;
    public event Action BlockObstacleSpawnEvent;
    public event Action GroundDestroyEvent;

    public static bool spawnObstacle = false;
    public static int abilityToSpawnCooldown = 2;
    public static bool canSpawnObstacle = true;
    private double xSpeed = DesignerClass.xStartingSpeed;

    public Spike(string fileName, int colums, int rows, TiledObject spikeObject = null) : base(fileName, colums, rows, -1, false, true)
    {
        if (spikeObject != null)
        {

        }
    }

    void Update()
    {
        /*
        if (Player.currentlyCrouched)
        {

            x -= (float)xSpeed * Player.xCrouchSpeed;
            Player.xCrouchSpeed -= DesignerClass.playerCrouchSpeedDecrease;
            if (Player.xCrouchSpeed < 0.5) Player.xCrouchSpeed = 0.5f;
        }
        else
        {
            x -= (float)xSpeed;
            Player.xCrouchSpeed = DesignerClass.playerCrouchStartingSpeed;
        }

        xSpeed += DesignerClass.XSpeedUp;
        */
    }
}