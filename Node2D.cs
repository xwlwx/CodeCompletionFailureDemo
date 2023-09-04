using Godot;
using System;

public partial class Node2D : Godot.Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("tab complete works for these methods");
		GD.Print("hello");
	}

	//when adding an override for the _PhysicsProcess method here,
	//I get a suggestion for the _PhysicsProcess method name to override,
	//but hitting tab will not autocomplete

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
