﻿using UnityEngine;

public class MyColors {
	public static int BUILDING = 0xE8E8E8;
	public static int GROUND = 0x81A377;
	public static int TREE = 0x216E41;
	public static int WHITE = 0xffffff;
	public static int BLACK = 0x000000;
	public static int DARK_BROWN = 0x545247;
	public static int LIGHT_BROWN = 0x736B5C;
	public static int GREY = 0x999999;
	public static int WATER = 0x4B95DE;
	public static int TRAIN = 0x444444;
	public static int CARS = 0xCC4E4E;

	public static bool ColorsEqual (Color a, Color b) {
		float err = Mathf.Abs(a.r - b.r) + Mathf.Abs(a.g - b.g) + Mathf.Abs(a.b - b.b);
		return err < 0.001f;
	}
}