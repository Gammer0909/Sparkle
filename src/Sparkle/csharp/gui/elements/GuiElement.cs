using System.Numerics;
using Raylib_cs;
using Sparkle.csharp.graphics.util;
using Rectangle = Raylib_cs.Rectangle;

namespace Sparkle.csharp.gui.elements; 

public abstract class GuiElement : IDisposable {

    public readonly string Name;
    public bool Enabled;

    public Vector2 Position;
    public Vector2 Size;

    protected bool IsHovered;
    protected bool IsClicked;
    
    protected float WidthScale { get; private set; }
    protected float HeightScale { get; private set; }
    
    protected Vector2 CalcPos { get; private set; }
    protected Vector2 CalcSize { get; private set; }

    private Func<bool>? _clickFunc;

    public GuiElement(string name, Vector2 position, Vector2 size, Func<bool>? clickClickFunc) {
        this.Name = name;
        this.Enabled = true;
        this.Position = position;
        this.Size = size;
        this._clickFunc = clickClickFunc!;
    }
    
    protected internal virtual void Init() { }

    protected internal virtual void Update() {
        this.UpdateWindowScale();
        
        this.CalcPos = new Vector2(this.Position.X * this.WidthScale, this.Position.Y * this.HeightScale);
        
        float scaleFactor = Math.Min(this.WidthScale, this.HeightScale);
        this.CalcSize = new Vector2(this.Size.X * scaleFactor, this.Size.Y * scaleFactor);
        
        Rectangle rec = new Rectangle(this.CalcPos.X, this.CalcPos.Y, this.CalcSize.X, this.CalcSize.Y);
        if (ShapeHelper.CheckCollisionPointRec(Input.GetMousePosition(), rec)) {
            this.IsHovered = true;

            if (Input.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && this.Enabled) {
                this.IsClicked = this._clickFunc == null || this._clickFunc.Invoke();
            }
            else {
                this.IsClicked = false;
            }
        }
        else {
            this.IsHovered = false;
            this.IsClicked = false;
        }
    }
    
    protected internal virtual void FixedUpdate() { }

    protected internal abstract void Draw();
    
    private void UpdateWindowScale() {
        this.WidthScale = Game.Instance.Window.GetScreenWidth() / 1280F;
        this.HeightScale = Raylib.GetScreenHeight() / 720F;
    }
    
    public virtual void Dispose() { }
}