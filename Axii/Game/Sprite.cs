using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class Sprite{
    public Sprite(){
        this.Scale = new Vector2(1, 1);
        this.Position = new Vector2(0, 0);
    }
    public Sprite(Vector2 position, Vector2 scale, Texture2D texture){
        this.Position = position;
        this.Scale = scale;
        this.Texture = texture;
    }

    public Vector2 Position { get; private set; }
    public Texture2D Texture { get; set; }
    public Vector2 Scale { get; set;}
}
