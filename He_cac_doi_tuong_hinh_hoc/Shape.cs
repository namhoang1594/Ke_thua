﻿using System;
using System.Collections.Generic;
using System.Text;

namespace He_cac_doi_tuong_hinh_hoc
{
    class Shape
    {
        public string Color = "Green";
        public bool Filled = true;
        public Shape()
        {

        }

        public Shape(string Color, bool Filled)
        {
            this.Color = Color;
            this.Filled = Filled;
        }

        public String GetColor()
        {
            return Color;
        }

        public void SetColor(string Color)
        {
            this.Color = Color;
        }

        public bool GetFilled()
        {
            return Filled;
        }

        public void SetFilled(bool Filled)
        {
            this.Filled = Filled;
        }

        public override string ToString()
        {
            return "A Shape with color of " + GetColor() + " and " + (GetFilled() ? "filled" : "not filled");
        }
    }
}
