﻿module Drawable

open Microsoft.Xna.Framework

type Drawable = 
  {
    Position : Vector2
    Rotation : float
    Image    : string
  }