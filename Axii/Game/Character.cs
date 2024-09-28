using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
abstract class Character{
    public const float DefaultMaxSpeed = 10;
    public float Velocity { get; set; }
    public float Acceleration { get; set; }
    public float MaxSpeed { get; set; }
    public float XP { get; set; }
    
    public Character() {
        this.MaxSpeed = DefaultMaxSpeed;

    }
    public Character(float MaxSpeed) {
        this.MaxSpeed = MaxSpeed;
    }

    // TODO call this in some kind of update manager
    public virtual void Update(GameTime gameTime) {

    }

    public abstract void MoveLeft();
    public abstract void MoveRight();
    public abstract void AutoAttack();
        //
    // Summary:
    //      Dash can also refer to Jump
    public abstract void Dash();
    public abstract bool Inrange();
    public abstract List<Character> FindOthersInRange();
    public int GetLevel () {
        // TODO implement
        return -1;
    }
    
}