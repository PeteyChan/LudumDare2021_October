using Godot;
using System;

public class Witch : Control
{
    public void SetText(string value)
    {
        this.FindChild<Label>().Text = value;
    }
}
